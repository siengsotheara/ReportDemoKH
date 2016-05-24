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

namespace ReportDemo
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="EPower")]
	public partial class DBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTBL_LICENSE_GENERATE(TBL_LICENSE_GENERATE instance);
    partial void UpdateTBL_LICENSE_GENERATE(TBL_LICENSE_GENERATE instance);
    partial void DeleteTBL_LICENSE_GENERATE(TBL_LICENSE_GENERATE instance);
    partial void InsertTLKP_CUSTOMER_CONNECTION_TYPE(TLKP_CUSTOMER_CONNECTION_TYPE instance);
    partial void UpdateTLKP_CUSTOMER_CONNECTION_TYPE(TLKP_CUSTOMER_CONNECTION_TYPE instance);
    partial void DeleteTLKP_CUSTOMER_CONNECTION_TYPE(TLKP_CUSTOMER_CONNECTION_TYPE instance);
    partial void InsertTLKP_CUSTOMER_GROUP(TLKP_CUSTOMER_GROUP instance);
    partial void UpdateTLKP_CUSTOMER_GROUP(TLKP_CUSTOMER_GROUP instance);
    partial void DeleteTLKP_CUSTOMER_GROUP(TLKP_CUSTOMER_GROUP instance);
    partial void InsertTLKP_CURRENCY(TLKP_CURRENCY instance);
    partial void UpdateTLKP_CURRENCY(TLKP_CURRENCY instance);
    partial void DeleteTLKP_CURRENCY(TLKP_CURRENCY instance);
    #endregion
		
		public DBDataContext() : 
				base(global::ReportDemo.Properties.Settings.Default.EPowerConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TBL_LICENSE_GENERATE> TBL_LICENSE_GENERATEs
		{
			get
			{
				return this.GetTable<TBL_LICENSE_GENERATE>();
			}
		}
		
		public System.Data.Linq.Table<TLKP_CUSTOMER_CONNECTION_TYPE> TLKP_CUSTOMER_CONNECTION_TYPEs
		{
			get
			{
				return this.GetTable<TLKP_CUSTOMER_CONNECTION_TYPE>();
			}
		}
		
		public System.Data.Linq.Table<TLKP_CUSTOMER_GROUP> TLKP_CUSTOMER_GROUPs
		{
			get
			{
				return this.GetTable<TLKP_CUSTOMER_GROUP>();
			}
		}
		
		public System.Data.Linq.Table<TLKP_CURRENCY> TLKP_CURRENCies
		{
			get
			{
				return this.GetTable<TLKP_CURRENCY>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TBL_LICENSE_GENERATE")]
	public partial class TBL_LICENSE_GENERATE : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _LICENSE_GENERATE_ID;
		
		private int _SCHEDULE_ID;
		
		private System.DateTime _CREATE_ON;
		
		private string _CREATE_BY;
		
		private string _NOTE;
		
		private System.DateTime _LAST_MODIFIED;
		
		private bool _IS_ACTIVE;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLICENSE_GENERATE_IDChanging(int value);
    partial void OnLICENSE_GENERATE_IDChanged();
    partial void OnSCHEDULE_IDChanging(int value);
    partial void OnSCHEDULE_IDChanged();
    partial void OnCREATE_ONChanging(System.DateTime value);
    partial void OnCREATE_ONChanged();
    partial void OnCREATE_BYChanging(string value);
    partial void OnCREATE_BYChanged();
    partial void OnNOTEChanging(string value);
    partial void OnNOTEChanged();
    partial void OnLAST_MODIFIEDChanging(System.DateTime value);
    partial void OnLAST_MODIFIEDChanged();
    partial void OnIS_ACTIVEChanging(bool value);
    partial void OnIS_ACTIVEChanged();
    #endregion
		
		public TBL_LICENSE_GENERATE()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LICENSE_GENERATE_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int LICENSE_GENERATE_ID
		{
			get
			{
				return this._LICENSE_GENERATE_ID;
			}
			set
			{
				if ((this._LICENSE_GENERATE_ID != value))
				{
					this.OnLICENSE_GENERATE_IDChanging(value);
					this.SendPropertyChanging();
					this._LICENSE_GENERATE_ID = value;
					this.SendPropertyChanged("LICENSE_GENERATE_ID");
					this.OnLICENSE_GENERATE_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SCHEDULE_ID", DbType="Int NOT NULL")]
		public int SCHEDULE_ID
		{
			get
			{
				return this._SCHEDULE_ID;
			}
			set
			{
				if ((this._SCHEDULE_ID != value))
				{
					this.OnSCHEDULE_IDChanging(value);
					this.SendPropertyChanging();
					this._SCHEDULE_ID = value;
					this.SendPropertyChanged("SCHEDULE_ID");
					this.OnSCHEDULE_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CREATE_ON", DbType="DateTime NOT NULL")]
		public System.DateTime CREATE_ON
		{
			get
			{
				return this._CREATE_ON;
			}
			set
			{
				if ((this._CREATE_ON != value))
				{
					this.OnCREATE_ONChanging(value);
					this.SendPropertyChanging();
					this._CREATE_ON = value;
					this.SendPropertyChanged("CREATE_ON");
					this.OnCREATE_ONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CREATE_BY", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string CREATE_BY
		{
			get
			{
				return this._CREATE_BY;
			}
			set
			{
				if ((this._CREATE_BY != value))
				{
					this.OnCREATE_BYChanging(value);
					this.SendPropertyChanging();
					this._CREATE_BY = value;
					this.SendPropertyChanged("CREATE_BY");
					this.OnCREATE_BYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NOTE", DbType="NVarChar(500)")]
		public string NOTE
		{
			get
			{
				return this._NOTE;
			}
			set
			{
				if ((this._NOTE != value))
				{
					this.OnNOTEChanging(value);
					this.SendPropertyChanging();
					this._NOTE = value;
					this.SendPropertyChanged("NOTE");
					this.OnNOTEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LAST_MODIFIED", DbType="DateTime NOT NULL")]
		public System.DateTime LAST_MODIFIED
		{
			get
			{
				return this._LAST_MODIFIED;
			}
			set
			{
				if ((this._LAST_MODIFIED != value))
				{
					this.OnLAST_MODIFIEDChanging(value);
					this.SendPropertyChanging();
					this._LAST_MODIFIED = value;
					this.SendPropertyChanged("LAST_MODIFIED");
					this.OnLAST_MODIFIEDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IS_ACTIVE", DbType="Bit NOT NULL")]
		public bool IS_ACTIVE
		{
			get
			{
				return this._IS_ACTIVE;
			}
			set
			{
				if ((this._IS_ACTIVE != value))
				{
					this.OnIS_ACTIVEChanging(value);
					this.SendPropertyChanging();
					this._IS_ACTIVE = value;
					this.SendPropertyChanged("IS_ACTIVE");
					this.OnIS_ACTIVEChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TLKP_CUSTOMER_CONNECTION_TYPE")]
	public partial class TLKP_CUSTOMER_CONNECTION_TYPE : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CUSTOMER_CONNECTION_TYPE_ID;
		
		private string _CUSTOMER_CONNECTION_TYPE_NAME;
		
		private string _DESCRIPTION;
		
		private int _CURRENCY_ID;
		
		private decimal _TARIFF;
		
		private int _NONLICENSE_CUSTOMER_GROUP_ID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCUSTOMER_CONNECTION_TYPE_IDChanging(int value);
    partial void OnCUSTOMER_CONNECTION_TYPE_IDChanged();
    partial void OnCUSTOMER_CONNECTION_TYPE_NAMEChanging(string value);
    partial void OnCUSTOMER_CONNECTION_TYPE_NAMEChanged();
    partial void OnDESCRIPTIONChanging(string value);
    partial void OnDESCRIPTIONChanged();
    partial void OnCURRENCY_IDChanging(int value);
    partial void OnCURRENCY_IDChanged();
    partial void OnTARIFFChanging(decimal value);
    partial void OnTARIFFChanged();
    partial void OnNONLICENSE_CUSTOMER_GROUP_IDChanging(int value);
    partial void OnNONLICENSE_CUSTOMER_GROUP_IDChanged();
    #endregion
		
		public TLKP_CUSTOMER_CONNECTION_TYPE()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CUSTOMER_CONNECTION_TYPE_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int CUSTOMER_CONNECTION_TYPE_ID
		{
			get
			{
				return this._CUSTOMER_CONNECTION_TYPE_ID;
			}
			set
			{
				if ((this._CUSTOMER_CONNECTION_TYPE_ID != value))
				{
					this.OnCUSTOMER_CONNECTION_TYPE_IDChanging(value);
					this.SendPropertyChanging();
					this._CUSTOMER_CONNECTION_TYPE_ID = value;
					this.SendPropertyChanged("CUSTOMER_CONNECTION_TYPE_ID");
					this.OnCUSTOMER_CONNECTION_TYPE_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CUSTOMER_CONNECTION_TYPE_NAME", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string CUSTOMER_CONNECTION_TYPE_NAME
		{
			get
			{
				return this._CUSTOMER_CONNECTION_TYPE_NAME;
			}
			set
			{
				if ((this._CUSTOMER_CONNECTION_TYPE_NAME != value))
				{
					this.OnCUSTOMER_CONNECTION_TYPE_NAMEChanging(value);
					this.SendPropertyChanging();
					this._CUSTOMER_CONNECTION_TYPE_NAME = value;
					this.SendPropertyChanged("CUSTOMER_CONNECTION_TYPE_NAME");
					this.OnCUSTOMER_CONNECTION_TYPE_NAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DESCRIPTION", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string DESCRIPTION
		{
			get
			{
				return this._DESCRIPTION;
			}
			set
			{
				if ((this._DESCRIPTION != value))
				{
					this.OnDESCRIPTIONChanging(value);
					this.SendPropertyChanging();
					this._DESCRIPTION = value;
					this.SendPropertyChanged("DESCRIPTION");
					this.OnDESCRIPTIONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CURRENCY_ID", DbType="Int NOT NULL")]
		public int CURRENCY_ID
		{
			get
			{
				return this._CURRENCY_ID;
			}
			set
			{
				if ((this._CURRENCY_ID != value))
				{
					this.OnCURRENCY_IDChanging(value);
					this.SendPropertyChanging();
					this._CURRENCY_ID = value;
					this.SendPropertyChanged("CURRENCY_ID");
					this.OnCURRENCY_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TARIFF", DbType="Decimal(18,4) NOT NULL")]
		public decimal TARIFF
		{
			get
			{
				return this._TARIFF;
			}
			set
			{
				if ((this._TARIFF != value))
				{
					this.OnTARIFFChanging(value);
					this.SendPropertyChanging();
					this._TARIFF = value;
					this.SendPropertyChanged("TARIFF");
					this.OnTARIFFChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NONLICENSE_CUSTOMER_GROUP_ID", DbType="Int NOT NULL")]
		public int NONLICENSE_CUSTOMER_GROUP_ID
		{
			get
			{
				return this._NONLICENSE_CUSTOMER_GROUP_ID;
			}
			set
			{
				if ((this._NONLICENSE_CUSTOMER_GROUP_ID != value))
				{
					this.OnNONLICENSE_CUSTOMER_GROUP_IDChanging(value);
					this.SendPropertyChanging();
					this._NONLICENSE_CUSTOMER_GROUP_ID = value;
					this.SendPropertyChanged("NONLICENSE_CUSTOMER_GROUP_ID");
					this.OnNONLICENSE_CUSTOMER_GROUP_IDChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TLKP_CUSTOMER_GROUP")]
	public partial class TLKP_CUSTOMER_GROUP : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CUSTOMER_GROUP_ID;
		
		private string _CUSTOMER_GROUP_NAME;
		
		private string _DESCRIPTION;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCUSTOMER_GROUP_IDChanging(int value);
    partial void OnCUSTOMER_GROUP_IDChanged();
    partial void OnCUSTOMER_GROUP_NAMEChanging(string value);
    partial void OnCUSTOMER_GROUP_NAMEChanged();
    partial void OnDESCRIPTIONChanging(string value);
    partial void OnDESCRIPTIONChanged();
    #endregion
		
		public TLKP_CUSTOMER_GROUP()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CUSTOMER_GROUP_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int CUSTOMER_GROUP_ID
		{
			get
			{
				return this._CUSTOMER_GROUP_ID;
			}
			set
			{
				if ((this._CUSTOMER_GROUP_ID != value))
				{
					this.OnCUSTOMER_GROUP_IDChanging(value);
					this.SendPropertyChanging();
					this._CUSTOMER_GROUP_ID = value;
					this.SendPropertyChanged("CUSTOMER_GROUP_ID");
					this.OnCUSTOMER_GROUP_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CUSTOMER_GROUP_NAME", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string CUSTOMER_GROUP_NAME
		{
			get
			{
				return this._CUSTOMER_GROUP_NAME;
			}
			set
			{
				if ((this._CUSTOMER_GROUP_NAME != value))
				{
					this.OnCUSTOMER_GROUP_NAMEChanging(value);
					this.SendPropertyChanging();
					this._CUSTOMER_GROUP_NAME = value;
					this.SendPropertyChanged("CUSTOMER_GROUP_NAME");
					this.OnCUSTOMER_GROUP_NAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DESCRIPTION", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string DESCRIPTION
		{
			get
			{
				return this._DESCRIPTION;
			}
			set
			{
				if ((this._DESCRIPTION != value))
				{
					this.OnDESCRIPTIONChanging(value);
					this.SendPropertyChanging();
					this._DESCRIPTION = value;
					this.SendPropertyChanged("DESCRIPTION");
					this.OnDESCRIPTIONChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TLKP_CURRENCY")]
	public partial class TLKP_CURRENCY : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CURRENCY_ID;
		
		private string _CURRENCY_NAME;
		
		private bool _IS_DEFAULT_CURRENCY;
		
		private int _DIGITS_AFTER_DECIMAL;
		
		private string _CURRENCY_SING;
		
		private string _CURRENCY_CODE;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCURRENCY_IDChanging(int value);
    partial void OnCURRENCY_IDChanged();
    partial void OnCURRENCY_NAMEChanging(string value);
    partial void OnCURRENCY_NAMEChanged();
    partial void OnIS_DEFAULT_CURRENCYChanging(bool value);
    partial void OnIS_DEFAULT_CURRENCYChanged();
    partial void OnDIGITS_AFTER_DECIMALChanging(int value);
    partial void OnDIGITS_AFTER_DECIMALChanged();
    partial void OnCURRENCY_SINGChanging(string value);
    partial void OnCURRENCY_SINGChanged();
    partial void OnCURRENCY_CODEChanging(string value);
    partial void OnCURRENCY_CODEChanged();
    #endregion
		
		public TLKP_CURRENCY()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CURRENCY_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int CURRENCY_ID
		{
			get
			{
				return this._CURRENCY_ID;
			}
			set
			{
				if ((this._CURRENCY_ID != value))
				{
					this.OnCURRENCY_IDChanging(value);
					this.SendPropertyChanging();
					this._CURRENCY_ID = value;
					this.SendPropertyChanged("CURRENCY_ID");
					this.OnCURRENCY_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CURRENCY_NAME", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string CURRENCY_NAME
		{
			get
			{
				return this._CURRENCY_NAME;
			}
			set
			{
				if ((this._CURRENCY_NAME != value))
				{
					this.OnCURRENCY_NAMEChanging(value);
					this.SendPropertyChanging();
					this._CURRENCY_NAME = value;
					this.SendPropertyChanged("CURRENCY_NAME");
					this.OnCURRENCY_NAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IS_DEFAULT_CURRENCY", DbType="Bit NOT NULL")]
		public bool IS_DEFAULT_CURRENCY
		{
			get
			{
				return this._IS_DEFAULT_CURRENCY;
			}
			set
			{
				if ((this._IS_DEFAULT_CURRENCY != value))
				{
					this.OnIS_DEFAULT_CURRENCYChanging(value);
					this.SendPropertyChanging();
					this._IS_DEFAULT_CURRENCY = value;
					this.SendPropertyChanged("IS_DEFAULT_CURRENCY");
					this.OnIS_DEFAULT_CURRENCYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIGITS_AFTER_DECIMAL", DbType="Int NOT NULL")]
		public int DIGITS_AFTER_DECIMAL
		{
			get
			{
				return this._DIGITS_AFTER_DECIMAL;
			}
			set
			{
				if ((this._DIGITS_AFTER_DECIMAL != value))
				{
					this.OnDIGITS_AFTER_DECIMALChanging(value);
					this.SendPropertyChanging();
					this._DIGITS_AFTER_DECIMAL = value;
					this.SendPropertyChanged("DIGITS_AFTER_DECIMAL");
					this.OnDIGITS_AFTER_DECIMALChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CURRENCY_SING", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string CURRENCY_SING
		{
			get
			{
				return this._CURRENCY_SING;
			}
			set
			{
				if ((this._CURRENCY_SING != value))
				{
					this.OnCURRENCY_SINGChanging(value);
					this.SendPropertyChanging();
					this._CURRENCY_SING = value;
					this.SendPropertyChanged("CURRENCY_SING");
					this.OnCURRENCY_SINGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CURRENCY_CODE", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string CURRENCY_CODE
		{
			get
			{
				return this._CURRENCY_CODE;
			}
			set
			{
				if ((this._CURRENCY_CODE != value))
				{
					this.OnCURRENCY_CODEChanging(value);
					this.SendPropertyChanging();
					this._CURRENCY_CODE = value;
					this.SendPropertyChanged("CURRENCY_CODE");
					this.OnCURRENCY_CODEChanged();
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
}
#pragma warning restore 1591