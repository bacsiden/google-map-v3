﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("MapModel", "FK_Marker_UtilityKind", "UtilityKind", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(MVC_GMap.UtilityKind), "Marker", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MVC_GMap.Marker), true)]
[assembly: EdmRelationshipAttribute("MapModel", "FK_DuAn_KhuVuc", "KhuVuc", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(MVC_GMap.KhuVuc), "DuAn", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MVC_GMap.DuAn), true)]

#endregion

namespace MVC_GMap
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class MapEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new MapEntities object using the connection string found in the 'MapEntities' section of the application configuration file.
        /// </summary>
        public MapEntities() : base("name=MapEntities", "MapEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MapEntities object.
        /// </summary>
        public MapEntities(string connectionString) : base(connectionString, "MapEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MapEntities object.
        /// </summary>
        public MapEntities(EntityConnection connection) : base(connection, "MapEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Marker> Marker
        {
            get
            {
                if ((_Marker == null))
                {
                    _Marker = base.CreateObjectSet<Marker>("Marker");
                }
                return _Marker;
            }
        }
        private ObjectSet<Marker> _Marker;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<UtilityKind> UtilityKind
        {
            get
            {
                if ((_UtilityKind == null))
                {
                    _UtilityKind = base.CreateObjectSet<UtilityKind>("UtilityKind");
                }
                return _UtilityKind;
            }
        }
        private ObjectSet<UtilityKind> _UtilityKind;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<DataDA> DataDA
        {
            get
            {
                if ((_DataDA == null))
                {
                    _DataDA = base.CreateObjectSet<DataDA>("DataDA");
                }
                return _DataDA;
            }
        }
        private ObjectSet<DataDA> _DataDA;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<KhuVuc> KhuVuc
        {
            get
            {
                if ((_KhuVuc == null))
                {
                    _KhuVuc = base.CreateObjectSet<KhuVuc>("KhuVuc");
                }
                return _KhuVuc;
            }
        }
        private ObjectSet<KhuVuc> _KhuVuc;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<DuAn> DuAn
        {
            get
            {
                if ((_DuAn == null))
                {
                    _DuAn = base.CreateObjectSet<DuAn>("DuAn");
                }
                return _DuAn;
            }
        }
        private ObjectSet<DuAn> _DuAn;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Marker EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToMarker(Marker marker)
        {
            base.AddObject("Marker", marker);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the UtilityKind EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToUtilityKind(UtilityKind utilityKind)
        {
            base.AddObject("UtilityKind", utilityKind);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the DataDA EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToDataDA(DataDA dataDA)
        {
            base.AddObject("DataDA", dataDA);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the KhuVuc EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToKhuVuc(KhuVuc khuVuc)
        {
            base.AddObject("KhuVuc", khuVuc);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the DuAn EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToDuAn(DuAn duAn)
        {
            base.AddObject("DuAn", duAn);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MapModel", Name="DataDA")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class DataDA : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new DataDA object.
        /// </summary>
        /// <param name="center">Initial value of the Center property.</param>
        public static DataDA CreateDataDA(global::System.String center)
        {
            DataDA dataDA = new DataDA();
            dataDA.Center = center;
            return dataDA;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String LatLng
        {
            get
            {
                return _LatLng;
            }
            set
            {
                OnLatLngChanging(value);
                ReportPropertyChanging("LatLng");
                _LatLng = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("LatLng");
                OnLatLngChanged();
            }
        }
        private global::System.String _LatLng;
        partial void OnLatLngChanging(global::System.String value);
        partial void OnLatLngChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Center
        {
            get
            {
                return _Center;
            }
            set
            {
                if (_Center != value)
                {
                    OnCenterChanging(value);
                    ReportPropertyChanging("Center");
                    _Center = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("Center");
                    OnCenterChanged();
                }
            }
        }
        private global::System.String _Center;
        partial void OnCenterChanging(global::System.String value);
        partial void OnCenterChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MapModel", Name="DuAn")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class DuAn : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new DuAn object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        public static DuAn CreateDuAn(global::System.Int32 id)
        {
            DuAn duAn = new DuAn();
            duAn.ID = id;
            return duAn;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> MaKhuVuc
        {
            get
            {
                return _MaKhuVuc;
            }
            set
            {
                OnMaKhuVucChanging(value);
                ReportPropertyChanging("MaKhuVuc");
                _MaKhuVuc = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("MaKhuVuc");
                OnMaKhuVucChanged();
            }
        }
        private Nullable<global::System.Int32> _MaKhuVuc;
        partial void OnMaKhuVucChanging(Nullable<global::System.Int32> value);
        partial void OnMaKhuVucChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String TenDuAn
        {
            get
            {
                return _TenDuAn;
            }
            set
            {
                OnTenDuAnChanging(value);
                ReportPropertyChanging("TenDuAn");
                _TenDuAn = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("TenDuAn");
                OnTenDuAnChanged();
            }
        }
        private global::System.String _TenDuAn;
        partial void OnTenDuAnChanging(global::System.String value);
        partial void OnTenDuAnChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ToaDo
        {
            get
            {
                return _ToaDo;
            }
            set
            {
                OnToaDoChanging(value);
                ReportPropertyChanging("ToaDo");
                _ToaDo = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ToaDo");
                OnToaDoChanged();
            }
        }
        private global::System.String _ToaDo;
        partial void OnToaDoChanging(global::System.String value);
        partial void OnToaDoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String AnhDaiDien
        {
            get
            {
                return _AnhDaiDien;
            }
            set
            {
                OnAnhDaiDienChanging(value);
                ReportPropertyChanging("AnhDaiDien");
                _AnhDaiDien = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("AnhDaiDien");
                OnAnhDaiDienChanged();
            }
        }
        private global::System.String _AnhDaiDien;
        partial void OnAnhDaiDienChanging(global::System.String value);
        partial void OnAnhDaiDienChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String DienTich
        {
            get
            {
                return _DienTich;
            }
            set
            {
                OnDienTichChanging(value);
                ReportPropertyChanging("DienTich");
                _DienTich = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("DienTich");
                OnDienTichChanged();
            }
        }
        private global::System.String _DienTich;
        partial void OnDienTichChanging(global::System.String value);
        partial void OnDienTichChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String GiaThue
        {
            get
            {
                return _GiaThue;
            }
            set
            {
                OnGiaThueChanging(value);
                ReportPropertyChanging("GiaThue");
                _GiaThue = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("GiaThue");
                OnGiaThueChanged();
            }
        }
        private global::System.String _GiaThue;
        partial void OnGiaThueChanging(global::System.String value);
        partial void OnGiaThueChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String TrangThai
        {
            get
            {
                return _TrangThai;
            }
            set
            {
                OnTrangThaiChanging(value);
                ReportPropertyChanging("TrangThai");
                _TrangThai = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("TrangThai");
                OnTrangThaiChanged();
            }
        }
        private global::System.String _TrangThai;
        partial void OnTrangThaiChanging(global::System.String value);
        partial void OnTrangThaiChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String VungBien
        {
            get
            {
                return _VungBien;
            }
            set
            {
                OnVungBienChanging(value);
                ReportPropertyChanging("VungBien");
                _VungBien = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("VungBien");
                OnVungBienChanged();
            }
        }
        private global::System.String _VungBien;
        partial void OnVungBienChanging(global::System.String value);
        partial void OnVungBienChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String AnhIcon
        {
            get
            {
                return _AnhIcon;
            }
            set
            {
                OnAnhIconChanging(value);
                ReportPropertyChanging("AnhIcon");
                _AnhIcon = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("AnhIcon");
                OnAnhIconChanged();
            }
        }
        private global::System.String _AnhIcon;
        partial void OnAnhIconChanging(global::System.String value);
        partial void OnAnhIconChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MapModel", "FK_DuAn_KhuVuc", "KhuVuc")]
        public KhuVuc KhuVuc
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<KhuVuc>("MapModel.FK_DuAn_KhuVuc", "KhuVuc").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<KhuVuc>("MapModel.FK_DuAn_KhuVuc", "KhuVuc").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<KhuVuc> KhuVucReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<KhuVuc>("MapModel.FK_DuAn_KhuVuc", "KhuVuc");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<KhuVuc>("MapModel.FK_DuAn_KhuVuc", "KhuVuc", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MapModel", Name="KhuVuc")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class KhuVuc : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new KhuVuc object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        public static KhuVuc CreateKhuVuc(global::System.Int32 id)
        {
            KhuVuc khuVuc = new KhuVuc();
            khuVuc.ID = id;
            return khuVuc;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Location
        {
            get
            {
                return _Location;
            }
            set
            {
                OnLocationChanging(value);
                ReportPropertyChanging("Location");
                _Location = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Location");
                OnLocationChanged();
            }
        }
        private global::System.String _Location;
        partial void OnLocationChanging(global::System.String value);
        partial void OnLocationChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MapModel", "FK_DuAn_KhuVuc", "DuAn")]
        public EntityCollection<DuAn> DuAn
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<DuAn>("MapModel.FK_DuAn_KhuVuc", "DuAn");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<DuAn>("MapModel.FK_DuAn_KhuVuc", "DuAn", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MapModel", Name="Marker")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Marker : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Marker object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        public static Marker CreateMarker(global::System.Int32 id)
        {
            Marker marker = new Marker();
            marker.ID = id;
            return marker;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ImgUrl
        {
            get
            {
                return _ImgUrl;
            }
            set
            {
                OnImgUrlChanging(value);
                ReportPropertyChanging("ImgUrl");
                _ImgUrl = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ImgUrl");
                OnImgUrlChanged();
            }
        }
        private global::System.String _ImgUrl;
        partial void OnImgUrlChanging(global::System.String value);
        partial void OnImgUrlChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> LayerID
        {
            get
            {
                return _LayerID;
            }
            set
            {
                OnLayerIDChanging(value);
                ReportPropertyChanging("LayerID");
                _LayerID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("LayerID");
                OnLayerIDChanged();
            }
        }
        private Nullable<global::System.Int32> _LayerID;
        partial void OnLayerIDChanging(Nullable<global::System.Int32> value);
        partial void OnLayerIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Position
        {
            get
            {
                return _Position;
            }
            set
            {
                OnPositionChanging(value);
                ReportPropertyChanging("Position");
                _Position = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Position");
                OnPositionChanged();
            }
        }
        private global::System.String _Position;
        partial void OnPositionChanging(global::System.String value);
        partial void OnPositionChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MapModel", "FK_Marker_UtilityKind", "UtilityKind")]
        public UtilityKind UtilityKind
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<UtilityKind>("MapModel.FK_Marker_UtilityKind", "UtilityKind").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<UtilityKind>("MapModel.FK_Marker_UtilityKind", "UtilityKind").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<UtilityKind> UtilityKindReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<UtilityKind>("MapModel.FK_Marker_UtilityKind", "UtilityKind");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<UtilityKind>("MapModel.FK_Marker_UtilityKind", "UtilityKind", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MapModel", Name="UtilityKind")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class UtilityKind : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new UtilityKind object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        public static UtilityKind CreateUtilityKind(global::System.Int32 id)
        {
            UtilityKind utilityKind = new UtilityKind();
            utilityKind.ID = id;
            return utilityKind;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MapModel", "FK_Marker_UtilityKind", "Marker")]
        public EntityCollection<Marker> Marker
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Marker>("MapModel.FK_Marker_UtilityKind", "Marker");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Marker>("MapModel.FK_Marker_UtilityKind", "Marker", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}