﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SHOP_PET.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="petdb")]
	public partial class dbPetDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertChiTietDonHang(ChiTietDonHang instance);
    partial void UpdateChiTietDonHang(ChiTietDonHang instance);
    partial void DeleteChiTietDonHang(ChiTietDonHang instance);
    partial void InsertTheLoai(TheLoai instance);
    partial void UpdateTheLoai(TheLoai instance);
    partial void DeleteTheLoai(TheLoai instance);
    partial void InsertDonHang(DonHang instance);
    partial void UpdateDonHang(DonHang instance);
    partial void DeleteDonHang(DonHang instance);
    partial void InsertKhachHang(KhachHang instance);
    partial void UpdateKhachHang(KhachHang instance);
    partial void DeleteKhachHang(KhachHang instance);
    partial void InsertPet(Pet instance);
    partial void UpdatePet(Pet instance);
    partial void DeletePet(Pet instance);
    #endregion
		
		public dbPetDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["petdbConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dbPetDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbPetDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbPetDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbPetDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ChiTietDonHang> ChiTietDonHangs
		{
			get
			{
				return this.GetTable<ChiTietDonHang>();
			}
		}
		
		public System.Data.Linq.Table<TheLoai> TheLoais
		{
			get
			{
				return this.GetTable<TheLoai>();
			}
		}
		
		public System.Data.Linq.Table<DonHang> DonHangs
		{
			get
			{
				return this.GetTable<DonHang>();
			}
		}
		
		public System.Data.Linq.Table<KhachHang> KhachHangs
		{
			get
			{
				return this.GetTable<KhachHang>();
			}
		}
		
		public System.Data.Linq.Table<Pet> Pets
		{
			get
			{
				return this.GetTable<Pet>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ChiTietDonHang")]
	public partial class ChiTietDonHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _madon;
		
		private int _mapet;
		
		private int _soluong;
		
		private decimal _gia;
		
		private System.Nullable<int> _Phuongthucthanhtoan;
		
		private EntityRef<DonHang> _DonHang;
		
		private EntityRef<Pet> _Pet;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmadonChanging(int value);
    partial void OnmadonChanged();
    partial void OnmapetChanging(int value);
    partial void OnmapetChanged();
    partial void OnsoluongChanging(int value);
    partial void OnsoluongChanged();
    partial void OngiaChanging(decimal value);
    partial void OngiaChanged();
    partial void OnPhuongthucthanhtoanChanging(System.Nullable<int> value);
    partial void OnPhuongthucthanhtoanChanged();
    #endregion
		
		public ChiTietDonHang()
		{
			this._DonHang = default(EntityRef<DonHang>);
			this._Pet = default(EntityRef<Pet>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_madon", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int madon
		{
			get
			{
				return this._madon;
			}
			set
			{
				if ((this._madon != value))
				{
					if (this._DonHang.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmadonChanging(value);
					this.SendPropertyChanging();
					this._madon = value;
					this.SendPropertyChanged("madon");
					this.OnmadonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mapet", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int mapet
		{
			get
			{
				return this._mapet;
			}
			set
			{
				if ((this._mapet != value))
				{
					if (this._Pet.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmapetChanging(value);
					this.SendPropertyChanging();
					this._mapet = value;
					this.SendPropertyChanged("mapet");
					this.OnmapetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_soluong", DbType="Int NOT NULL")]
		public int soluong
		{
			get
			{
				return this._soluong;
			}
			set
			{
				if ((this._soluong != value))
				{
					this.OnsoluongChanging(value);
					this.SendPropertyChanging();
					this._soluong = value;
					this.SendPropertyChanged("soluong");
					this.OnsoluongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gia", DbType="Decimal(18,0) NOT NULL")]
		public decimal gia
		{
			get
			{
				return this._gia;
			}
			set
			{
				if ((this._gia != value))
				{
					this.OngiaChanging(value);
					this.SendPropertyChanging();
					this._gia = value;
					this.SendPropertyChanged("gia");
					this.OngiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phuongthucthanhtoan", DbType="Int")]
		public System.Nullable<int> Phuongthucthanhtoan
		{
			get
			{
				return this._Phuongthucthanhtoan;
			}
			set
			{
				if ((this._Phuongthucthanhtoan != value))
				{
					this.OnPhuongthucthanhtoanChanging(value);
					this.SendPropertyChanging();
					this._Phuongthucthanhtoan = value;
					this.SendPropertyChanged("Phuongthucthanhtoan");
					this.OnPhuongthucthanhtoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DonHang_ChiTietDonHang", Storage="_DonHang", ThisKey="madon", OtherKey="madon", IsForeignKey=true)]
		public DonHang DonHang
		{
			get
			{
				return this._DonHang.Entity;
			}
			set
			{
				DonHang previousValue = this._DonHang.Entity;
				if (((previousValue != value) 
							|| (this._DonHang.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DonHang.Entity = null;
						previousValue.ChiTietDonHangs.Remove(this);
					}
					this._DonHang.Entity = value;
					if ((value != null))
					{
						value.ChiTietDonHangs.Add(this);
						this._madon = value.madon;
					}
					else
					{
						this._madon = default(int);
					}
					this.SendPropertyChanged("DonHang");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Pet_ChiTietDonHang", Storage="_Pet", ThisKey="mapet", OtherKey="mapet", IsForeignKey=true)]
		public Pet Pet
		{
			get
			{
				return this._Pet.Entity;
			}
			set
			{
				Pet previousValue = this._Pet.Entity;
				if (((previousValue != value) 
							|| (this._Pet.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Pet.Entity = null;
						previousValue.ChiTietDonHangs.Remove(this);
					}
					this._Pet.Entity = value;
					if ((value != null))
					{
						value.ChiTietDonHangs.Add(this);
						this._mapet = value.mapet;
					}
					else
					{
						this._mapet = default(int);
					}
					this.SendPropertyChanged("Pet");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TheLoai")]
	public partial class TheLoai : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _maloai;
		
		private string _tenloai;
		
		private EntitySet<Pet> _Pets;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmaloaiChanging(int value);
    partial void OnmaloaiChanged();
    partial void OntenloaiChanging(string value);
    partial void OntenloaiChanged();
    #endregion
		
		public TheLoai()
		{
			this._Pets = new EntitySet<Pet>(new Action<Pet>(this.attach_Pets), new Action<Pet>(this.detach_Pets));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maloai", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int maloai
		{
			get
			{
				return this._maloai;
			}
			set
			{
				if ((this._maloai != value))
				{
					this.OnmaloaiChanging(value);
					this.SendPropertyChanging();
					this._maloai = value;
					this.SendPropertyChanged("maloai");
					this.OnmaloaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenloai", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string tenloai
		{
			get
			{
				return this._tenloai;
			}
			set
			{
				if ((this._tenloai != value))
				{
					this.OntenloaiChanging(value);
					this.SendPropertyChanging();
					this._tenloai = value;
					this.SendPropertyChanged("tenloai");
					this.OntenloaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TheLoai_Pet", Storage="_Pets", ThisKey="maloai", OtherKey="maloai")]
		public EntitySet<Pet> Pets
		{
			get
			{
				return this._Pets;
			}
			set
			{
				this._Pets.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Pets(Pet entity)
		{
			this.SendPropertyChanging();
			entity.TheLoai = this;
		}
		
		private void detach_Pets(Pet entity)
		{
			this.SendPropertyChanging();
			entity.TheLoai = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DonHang")]
	public partial class DonHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _madon;
		
		private decimal _thanhtoan;
		
		private bool _giaohang;
		
		private System.DateTime _ngaydat;
		
		private System.DateTime _ngaygiao;
		
		private int _makh;
		
		private EntitySet<ChiTietDonHang> _ChiTietDonHangs;
		
		private EntityRef<KhachHang> _KhachHang;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmadonChanging(int value);
    partial void OnmadonChanged();
    partial void OnthanhtoanChanging(decimal value);
    partial void OnthanhtoanChanged();
    partial void OngiaohangChanging(bool value);
    partial void OngiaohangChanged();
    partial void OnngaydatChanging(System.DateTime value);
    partial void OnngaydatChanged();
    partial void OnngaygiaoChanging(System.DateTime value);
    partial void OnngaygiaoChanged();
    partial void OnmakhChanging(int value);
    partial void OnmakhChanged();
    #endregion
		
		public DonHang()
		{
			this._ChiTietDonHangs = new EntitySet<ChiTietDonHang>(new Action<ChiTietDonHang>(this.attach_ChiTietDonHangs), new Action<ChiTietDonHang>(this.detach_ChiTietDonHangs));
			this._KhachHang = default(EntityRef<KhachHang>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_madon", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int madon
		{
			get
			{
				return this._madon;
			}
			set
			{
				if ((this._madon != value))
				{
					this.OnmadonChanging(value);
					this.SendPropertyChanging();
					this._madon = value;
					this.SendPropertyChanged("madon");
					this.OnmadonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_thanhtoan", DbType="Decimal(18,0) NOT NULL")]
		public decimal thanhtoan
		{
			get
			{
				return this._thanhtoan;
			}
			set
			{
				if ((this._thanhtoan != value))
				{
					this.OnthanhtoanChanging(value);
					this.SendPropertyChanging();
					this._thanhtoan = value;
					this.SendPropertyChanged("thanhtoan");
					this.OnthanhtoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_giaohang", DbType="Bit NOT NULL")]
		public bool giaohang
		{
			get
			{
				return this._giaohang;
			}
			set
			{
				if ((this._giaohang != value))
				{
					this.OngiaohangChanging(value);
					this.SendPropertyChanging();
					this._giaohang = value;
					this.SendPropertyChanged("giaohang");
					this.OngiaohangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngaydat", DbType="Date NOT NULL")]
		public System.DateTime ngaydat
		{
			get
			{
				return this._ngaydat;
			}
			set
			{
				if ((this._ngaydat != value))
				{
					this.OnngaydatChanging(value);
					this.SendPropertyChanging();
					this._ngaydat = value;
					this.SendPropertyChanged("ngaydat");
					this.OnngaydatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngaygiao", DbType="Date NOT NULL")]
		public System.DateTime ngaygiao
		{
			get
			{
				return this._ngaygiao;
			}
			set
			{
				if ((this._ngaygiao != value))
				{
					this.OnngaygiaoChanging(value);
					this.SendPropertyChanging();
					this._ngaygiao = value;
					this.SendPropertyChanged("ngaygiao");
					this.OnngaygiaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_makh", DbType="Int NOT NULL")]
		public int makh
		{
			get
			{
				return this._makh;
			}
			set
			{
				if ((this._makh != value))
				{
					if (this._KhachHang.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmakhChanging(value);
					this.SendPropertyChanging();
					this._makh = value;
					this.SendPropertyChanged("makh");
					this.OnmakhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DonHang_ChiTietDonHang", Storage="_ChiTietDonHangs", ThisKey="madon", OtherKey="madon")]
		public EntitySet<ChiTietDonHang> ChiTietDonHangs
		{
			get
			{
				return this._ChiTietDonHangs;
			}
			set
			{
				this._ChiTietDonHangs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhachHang_DonHang", Storage="_KhachHang", ThisKey="makh", OtherKey="makh", IsForeignKey=true)]
		public KhachHang KhachHang
		{
			get
			{
				return this._KhachHang.Entity;
			}
			set
			{
				KhachHang previousValue = this._KhachHang.Entity;
				if (((previousValue != value) 
							|| (this._KhachHang.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KhachHang.Entity = null;
						previousValue.DonHangs.Remove(this);
					}
					this._KhachHang.Entity = value;
					if ((value != null))
					{
						value.DonHangs.Add(this);
						this._makh = value.makh;
					}
					else
					{
						this._makh = default(int);
					}
					this.SendPropertyChanged("KhachHang");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_ChiTietDonHangs(ChiTietDonHang entity)
		{
			this.SendPropertyChanging();
			entity.DonHang = this;
		}
		
		private void detach_ChiTietDonHangs(ChiTietDonHang entity)
		{
			this.SendPropertyChanging();
			entity.DonHang = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KhachHang")]
	public partial class KhachHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _makh;
		
		private string _hoten;
		
		private string _tendangnhap;
		
		private string _matkhau;
		
		private string _email;
		
		private string _diachi;
		
		private string _dienthoai;
		
		private System.DateTime _ngaysinh;
		
		private EntitySet<DonHang> _DonHangs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmakhChanging(int value);
    partial void OnmakhChanged();
    partial void OnhotenChanging(string value);
    partial void OnhotenChanged();
    partial void OntendangnhapChanging(string value);
    partial void OntendangnhapChanged();
    partial void OnmatkhauChanging(string value);
    partial void OnmatkhauChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OndiachiChanging(string value);
    partial void OndiachiChanged();
    partial void OndienthoaiChanging(string value);
    partial void OndienthoaiChanged();
    partial void OnngaysinhChanging(System.DateTime value);
    partial void OnngaysinhChanged();
    #endregion
		
		public KhachHang()
		{
			this._DonHangs = new EntitySet<DonHang>(new Action<DonHang>(this.attach_DonHangs), new Action<DonHang>(this.detach_DonHangs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_makh", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int makh
		{
			get
			{
				return this._makh;
			}
			set
			{
				if ((this._makh != value))
				{
					this.OnmakhChanging(value);
					this.SendPropertyChanging();
					this._makh = value;
					this.SendPropertyChanged("makh");
					this.OnmakhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hoten", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string hoten
		{
			get
			{
				return this._hoten;
			}
			set
			{
				if ((this._hoten != value))
				{
					this.OnhotenChanging(value);
					this.SendPropertyChanging();
					this._hoten = value;
					this.SendPropertyChanged("hoten");
					this.OnhotenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tendangnhap", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string tendangnhap
		{
			get
			{
				return this._tendangnhap;
			}
			set
			{
				if ((this._tendangnhap != value))
				{
					this.OntendangnhapChanging(value);
					this.SendPropertyChanging();
					this._tendangnhap = value;
					this.SendPropertyChanged("tendangnhap");
					this.OntendangnhapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_matkhau", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string matkhau
		{
			get
			{
				return this._matkhau;
			}
			set
			{
				if ((this._matkhau != value))
				{
					this.OnmatkhauChanging(value);
					this.SendPropertyChanging();
					this._matkhau = value;
					this.SendPropertyChanged("matkhau");
					this.OnmatkhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_diachi", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string diachi
		{
			get
			{
				return this._diachi;
			}
			set
			{
				if ((this._diachi != value))
				{
					this.OndiachiChanging(value);
					this.SendPropertyChanging();
					this._diachi = value;
					this.SendPropertyChanged("diachi");
					this.OndiachiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dienthoai", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
		public string dienthoai
		{
			get
			{
				return this._dienthoai;
			}
			set
			{
				if ((this._dienthoai != value))
				{
					this.OndienthoaiChanging(value);
					this.SendPropertyChanging();
					this._dienthoai = value;
					this.SendPropertyChanged("dienthoai");
					this.OndienthoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngaysinh", DbType="Date NOT NULL")]
		public System.DateTime ngaysinh
		{
			get
			{
				return this._ngaysinh;
			}
			set
			{
				if ((this._ngaysinh != value))
				{
					this.OnngaysinhChanging(value);
					this.SendPropertyChanging();
					this._ngaysinh = value;
					this.SendPropertyChanged("ngaysinh");
					this.OnngaysinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhachHang_DonHang", Storage="_DonHangs", ThisKey="makh", OtherKey="makh")]
		public EntitySet<DonHang> DonHangs
		{
			get
			{
				return this._DonHangs;
			}
			set
			{
				this._DonHangs.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_DonHangs(DonHang entity)
		{
			this.SendPropertyChanging();
			entity.KhachHang = this;
		}
		
		private void detach_DonHangs(DonHang entity)
		{
			this.SendPropertyChanging();
			entity.KhachHang = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Pet")]
	public partial class Pet : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _mapet;
		
		private int _maloai;
		
		private string _tenpet;
		
		private string _hinhpet;
		
		private decimal _giaban;
		
		private System.DateTime _ngaycapnhat;
		
		private decimal _trongluong;
		
		private int _soluongtong;
		
		private EntitySet<ChiTietDonHang> _ChiTietDonHangs;
		
		private EntityRef<TheLoai> _TheLoai;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmapetChanging(int value);
    partial void OnmapetChanged();
    partial void OnmaloaiChanging(int value);
    partial void OnmaloaiChanged();
    partial void OntenpetChanging(string value);
    partial void OntenpetChanged();
    partial void OnhinhpetChanging(string value);
    partial void OnhinhpetChanged();
    partial void OngiabanChanging(decimal value);
    partial void OngiabanChanged();
    partial void OnngaycapnhatChanging(System.DateTime value);
    partial void OnngaycapnhatChanged();
    partial void OntrongluongChanging(decimal value);
    partial void OntrongluongChanged();
    partial void OnsoluongtongChanging(int value);
    partial void OnsoluongtongChanged();
    #endregion
		
		public Pet()
		{
			this._ChiTietDonHangs = new EntitySet<ChiTietDonHang>(new Action<ChiTietDonHang>(this.attach_ChiTietDonHangs), new Action<ChiTietDonHang>(this.detach_ChiTietDonHangs));
			this._TheLoai = default(EntityRef<TheLoai>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mapet", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int mapet
		{
			get
			{
				return this._mapet;
			}
			set
			{
				if ((this._mapet != value))
				{
					this.OnmapetChanging(value);
					this.SendPropertyChanging();
					this._mapet = value;
					this.SendPropertyChanged("mapet");
					this.OnmapetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maloai", DbType="Int NOT NULL")]
		public int maloai
		{
			get
			{
				return this._maloai;
			}
			set
			{
				if ((this._maloai != value))
				{
					if (this._TheLoai.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmaloaiChanging(value);
					this.SendPropertyChanging();
					this._maloai = value;
					this.SendPropertyChanged("maloai");
					this.OnmaloaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenpet", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string tenpet
		{
			get
			{
				return this._tenpet;
			}
			set
			{
				if ((this._tenpet != value))
				{
					this.OntenpetChanging(value);
					this.SendPropertyChanging();
					this._tenpet = value;
					this.SendPropertyChanged("tenpet");
					this.OntenpetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hinhpet", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string hinhpet
		{
			get
			{
				return this._hinhpet;
			}
			set
			{
				if ((this._hinhpet != value))
				{
					this.OnhinhpetChanging(value);
					this.SendPropertyChanging();
					this._hinhpet = value;
					this.SendPropertyChanged("hinhpet");
					this.OnhinhpetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_giaban", DbType="Decimal(18,0) NOT NULL")]
		public decimal giaban
		{
			get
			{
				return this._giaban;
			}
			set
			{
				if ((this._giaban != value))
				{
					this.OngiabanChanging(value);
					this.SendPropertyChanging();
					this._giaban = value;
					this.SendPropertyChanged("giaban");
					this.OngiabanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngaycapnhat", DbType="SmallDateTime NOT NULL")]
		public System.DateTime ngaycapnhat
		{
			get
			{
				return this._ngaycapnhat;
			}
			set
			{
				if ((this._ngaycapnhat != value))
				{
					this.OnngaycapnhatChanging(value);
					this.SendPropertyChanging();
					this._ngaycapnhat = value;
					this.SendPropertyChanged("ngaycapnhat");
					this.OnngaycapnhatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_trongluong", DbType="Decimal(10,0) NOT NULL")]
		public decimal trongluong
		{
			get
			{
				return this._trongluong;
			}
			set
			{
				if ((this._trongluong != value))
				{
					this.OntrongluongChanging(value);
					this.SendPropertyChanging();
					this._trongluong = value;
					this.SendPropertyChanged("trongluong");
					this.OntrongluongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_soluongtong", DbType="Int NOT NULL")]
		public int soluongtong
		{
			get
			{
				return this._soluongtong;
			}
			set
			{
				if ((this._soluongtong != value))
				{
					this.OnsoluongtongChanging(value);
					this.SendPropertyChanging();
					this._soluongtong = value;
					this.SendPropertyChanged("soluongtong");
					this.OnsoluongtongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Pet_ChiTietDonHang", Storage="_ChiTietDonHangs", ThisKey="mapet", OtherKey="mapet")]
		public EntitySet<ChiTietDonHang> ChiTietDonHangs
		{
			get
			{
				return this._ChiTietDonHangs;
			}
			set
			{
				this._ChiTietDonHangs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TheLoai_Pet", Storage="_TheLoai", ThisKey="maloai", OtherKey="maloai", IsForeignKey=true)]
		public TheLoai TheLoai
		{
			get
			{
				return this._TheLoai.Entity;
			}
			set
			{
				TheLoai previousValue = this._TheLoai.Entity;
				if (((previousValue != value) 
							|| (this._TheLoai.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TheLoai.Entity = null;
						previousValue.Pets.Remove(this);
					}
					this._TheLoai.Entity = value;
					if ((value != null))
					{
						value.Pets.Add(this);
						this._maloai = value.maloai;
					}
					else
					{
						this._maloai = default(int);
					}
					this.SendPropertyChanged("TheLoai");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_ChiTietDonHangs(ChiTietDonHang entity)
		{
			this.SendPropertyChanging();
			entity.Pet = this;
		}
		
		private void detach_ChiTietDonHangs(ChiTietDonHang entity)
		{
			this.SendPropertyChanging();
			entity.Pet = null;
		}
	}
}
#pragma warning restore 1591
