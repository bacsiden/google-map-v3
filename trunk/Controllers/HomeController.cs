using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;

namespace MVC_GMap.Controllers
{
    public class AllData
    {
        public List<Marker> MarKer { get; set; }
        public List<DuAn> DataDuAn { get; set; }
        public List<KhuVuc> LstKhuVuc { get; set; }
    }

    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult TimDuong()
        {
            return View();
        }
        public ActionResult Index()
        {
            ViewBag.Zoom = 15;
            ViewBag.Point = "21.0216, 105.8012";
            ViewBag.MapType = "ROADMAP";//ROADMAP
            string s1 = "";
            foreach (var item in new MapEntities().UtilityKind)
            {
                s1 += item.ID + ";#" + item.Title + "__";
            }
            ViewBag.UK1 = s1;
            AllData data = new AllData();
            var lst = new MapEntities().Marker.ToList();
            data.MarKer = lst;
            data.DataDuAn = new MapEntities().DuAn.ToList();
            data.LstKhuVuc = new MapEntities().KhuVuc.ToList();
            
            return View(data);

        }

        [HttpPost]
        public string Index1(int node)
        {
            string s = "";
            int i = 0;
            foreach (var item in new MapEntities().Marker)
            {
                if (node == item.LayerID)
                    s += i + ";#";
                i++;
            }
            return s;
        }
        [HttpPost]
        public string Index2(string node)
        {
            var arr = node.Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

            if (arr.Length > 4)
            {
                DataDA obj = new DataDA();
                string center = "";
                string latLng = "";
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i == arr.Length - 1)
                    {
                        center = arr[i];
                    }
                    else
                    {
                        latLng += i == arr.Length - 2 ? arr[i] : arr[i] + ";";
                    }
                }
                obj.Center = center;
                obj.LatLng = latLng;

                var entities = new MapEntities();
                entities.DataDA.AddObject(obj);
                entities.SaveChanges();

                return "Success!";
            }
            return "Fail!";
        }
        [HttpPost]
        public int Index_ToaNha(int query)
        {
            var lst = new MapEntities().DuAn.ToList();
            for (int i = 0; i < lst.Count; i++)
			{
                if (lst[i].ID == query) return i;
			}
            return -1;
        }
        [HttpPost]
        public string Search(string query)
        {
            query = query.Trim();
            if (string.IsNullOrEmpty(query)) return "<ul>No resutl</ul>";
            var entities = new MapEntities();
            var kq1 = entities.Marker.Where(m => m.Title.Contains(query));
            var kq2 = entities.DuAn.Where(m => m.TenDuAn.Contains(query));
            string s1 = "";
            string s2 = "";
            foreach (var item in kq1)
            {
                s1 += "<li><a href='javascript:void(0)' onclick='gotoSeachPoint(" + item.Position + ");' class='liresult' style='text-decoration: none;'>" + item.Title + "</a></li>";
                s2 += item.Position + ";";
            }
            foreach (var item in kq2)
            {
                s1 += "<li><a href='javascript:void(0)'  onclick='gotoSeachPoint(" + item.ToaDo + ");' class='liresult' style='text-decoration: none;'>" + item.TenDuAn + "</a></li>";
                s2 += item.ToaDo + ";";
            }
            return "<ul>" + s1 + "</ul>" + ";#" + s2;
        }

        [HttpPost]
        public string TimDuong(string query)
        {
            string txtstart = query.Split(new char[]{';', '#'}, StringSplitOptions.RemoveEmptyEntries)[0];
            string txtend = query.Split(new char[] { ';', '#' }, StringSplitOptions.RemoveEmptyEntries)[1];
            string start = "";
            var entities = new MapEntities();
            if (entities.Marker.FirstOrDefault(m => m.Title == txtstart) != null)
            {
                start = entities.Marker.FirstOrDefault(m => m.Title == txtstart).Position;
            }
            else
                start = entities.DuAn.FirstOrDefault(m => m.TenDuAn == txtstart).ToaDo;

            string end = "";
            if (entities.DuAn.FirstOrDefault(m => m.TenDuAn == txtend) != null)
            {
                end = entities.DuAn.FirstOrDefault(m => m.TenDuAn == txtend).ToaDo;
            }
            else
                end = entities.Marker.FirstOrDefault(m => m.Title == txtend).Position;
            return start + ";#" + end;
        }
    }
}
