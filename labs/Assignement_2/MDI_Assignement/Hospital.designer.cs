﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MDI_Assignement
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Hospital")]
	public partial class HospitalDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Définitions de méthodes d'extensibilité
    partial void OnCreated();
    partial void InsertAppointments(Appointments instance);
    partial void UpdateAppointments(Appointments instance);
    partial void DeleteAppointments(Appointments instance);
    partial void InsertDoctors(Doctors instance);
    partial void UpdateDoctors(Doctors instance);
    partial void DeleteDoctors(Doctors instance);
    partial void InsertPatient(Patient instance);
    partial void UpdatePatient(Patient instance);
    partial void DeletePatient(Patient instance);
    #endregion
		
		public HospitalDataContext() : 
				base(global::MDI_Assignement.Properties.Settings.Default.HospitalConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public HospitalDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HospitalDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HospitalDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HospitalDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Appointments> Appointments
		{
			get
			{
				return this.GetTable<Appointments>();
			}
		}
		
		public System.Data.Linq.Table<Doctors> Doctors
		{
			get
			{
				return this.GetTable<Doctors>();
			}
		}
		
		public System.Data.Linq.Table<Patient> Patient
		{
			get
			{
				return this.GetTable<Patient>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Appointments")]
	public partial class Appointments : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AppointmentCode;
		
		private System.Nullable<System.DateTime> _AppointmentDate;
		
		private System.Nullable<System.TimeSpan> _AppointmentTime;
		
		private System.Nullable<int> _DoctorId;
		
		private System.Nullable<int> _PatientId;
		
		private EntityRef<Doctors> _Doctors;
		
		private EntityRef<Patient> _Patient;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAppointmentCodeChanging(int value);
    partial void OnAppointmentCodeChanged();
    partial void OnAppointmentDateChanging(System.Nullable<System.DateTime> value);
    partial void OnAppointmentDateChanged();
    partial void OnAppointmentTimeChanging(System.Nullable<System.TimeSpan> value);
    partial void OnAppointmentTimeChanged();
    partial void OnDoctorIdChanging(System.Nullable<int> value);
    partial void OnDoctorIdChanged();
    partial void OnPatientIdChanging(System.Nullable<int> value);
    partial void OnPatientIdChanged();
    #endregion
		
		public Appointments()
		{
			this._Doctors = default(EntityRef<Doctors>);
			this._Patient = default(EntityRef<Patient>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AppointmentCode", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int AppointmentCode
		{
			get
			{
				return this._AppointmentCode;
			}
			set
			{
				if ((this._AppointmentCode != value))
				{
					this.OnAppointmentCodeChanging(value);
					this.SendPropertyChanging();
					this._AppointmentCode = value;
					this.SendPropertyChanged("AppointmentCode");
					this.OnAppointmentCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AppointmentDate", DbType="Date")]
		public System.Nullable<System.DateTime> AppointmentDate
		{
			get
			{
				return this._AppointmentDate;
			}
			set
			{
				if ((this._AppointmentDate != value))
				{
					this.OnAppointmentDateChanging(value);
					this.SendPropertyChanging();
					this._AppointmentDate = value;
					this.SendPropertyChanged("AppointmentDate");
					this.OnAppointmentDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AppointmentTime", DbType="Time")]
		public System.Nullable<System.TimeSpan> AppointmentTime
		{
			get
			{
				return this._AppointmentTime;
			}
			set
			{
				if ((this._AppointmentTime != value))
				{
					this.OnAppointmentTimeChanging(value);
					this.SendPropertyChanging();
					this._AppointmentTime = value;
					this.SendPropertyChanged("AppointmentTime");
					this.OnAppointmentTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoctorId", DbType="Int")]
		public System.Nullable<int> DoctorId
		{
			get
			{
				return this._DoctorId;
			}
			set
			{
				if ((this._DoctorId != value))
				{
					if (this._Doctors.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDoctorIdChanging(value);
					this.SendPropertyChanging();
					this._DoctorId = value;
					this.SendPropertyChanged("DoctorId");
					this.OnDoctorIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PatientId", DbType="Int")]
		public System.Nullable<int> PatientId
		{
			get
			{
				return this._PatientId;
			}
			set
			{
				if ((this._PatientId != value))
				{
					if (this._Patient.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPatientIdChanging(value);
					this.SendPropertyChanging();
					this._PatientId = value;
					this.SendPropertyChanged("PatientId");
					this.OnPatientIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Doctors_Appointments", Storage="_Doctors", ThisKey="DoctorId", OtherKey="DoctorId", IsForeignKey=true)]
		public Doctors Doctors
		{
			get
			{
				return this._Doctors.Entity;
			}
			set
			{
				Doctors previousValue = this._Doctors.Entity;
				if (((previousValue != value) 
							|| (this._Doctors.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Doctors.Entity = null;
						previousValue.Appointments.Remove(this);
					}
					this._Doctors.Entity = value;
					if ((value != null))
					{
						value.Appointments.Add(this);
						this._DoctorId = value.DoctorId;
					}
					else
					{
						this._DoctorId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Doctors");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Patient_Appointments", Storage="_Patient", ThisKey="PatientId", OtherKey="PatientId", IsForeignKey=true)]
		public Patient Patient
		{
			get
			{
				return this._Patient.Entity;
			}
			set
			{
				Patient previousValue = this._Patient.Entity;
				if (((previousValue != value) 
							|| (this._Patient.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Patient.Entity = null;
						previousValue.Appointments.Remove(this);
					}
					this._Patient.Entity = value;
					if ((value != null))
					{
						value.Appointments.Add(this);
						this._PatientId = value.PatientId;
					}
					else
					{
						this._PatientId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Patient");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Doctors")]
	public partial class Doctors : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _DoctorId;
		
		private string _DoctorName;
		
		private string _DoctorTel;
		
		private System.Nullable<System.DateTime> _HiringDate;
		
		private string _DoctorSpecialism;
		
		private EntitySet<Appointments> _Appointments;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDoctorIdChanging(int value);
    partial void OnDoctorIdChanged();
    partial void OnDoctorNameChanging(string value);
    partial void OnDoctorNameChanged();
    partial void OnDoctorTelChanging(string value);
    partial void OnDoctorTelChanged();
    partial void OnHiringDateChanging(System.Nullable<System.DateTime> value);
    partial void OnHiringDateChanged();
    partial void OnDoctorSpecialismChanging(string value);
    partial void OnDoctorSpecialismChanged();
    #endregion
		
		public Doctors()
		{
			this._Appointments = new EntitySet<Appointments>(new Action<Appointments>(this.attach_Appointments), new Action<Appointments>(this.detach_Appointments));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoctorId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int DoctorId
		{
			get
			{
				return this._DoctorId;
			}
			set
			{
				if ((this._DoctorId != value))
				{
					this.OnDoctorIdChanging(value);
					this.SendPropertyChanging();
					this._DoctorId = value;
					this.SendPropertyChanged("DoctorId");
					this.OnDoctorIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoctorName", DbType="VarChar(50)")]
		public string DoctorName
		{
			get
			{
				return this._DoctorName;
			}
			set
			{
				if ((this._DoctorName != value))
				{
					this.OnDoctorNameChanging(value);
					this.SendPropertyChanging();
					this._DoctorName = value;
					this.SendPropertyChanged("DoctorName");
					this.OnDoctorNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoctorTel", DbType="VarChar(20)")]
		public string DoctorTel
		{
			get
			{
				return this._DoctorTel;
			}
			set
			{
				if ((this._DoctorTel != value))
				{
					this.OnDoctorTelChanging(value);
					this.SendPropertyChanging();
					this._DoctorTel = value;
					this.SendPropertyChanged("DoctorTel");
					this.OnDoctorTelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HiringDate", DbType="Date")]
		public System.Nullable<System.DateTime> HiringDate
		{
			get
			{
				return this._HiringDate;
			}
			set
			{
				if ((this._HiringDate != value))
				{
					this.OnHiringDateChanging(value);
					this.SendPropertyChanging();
					this._HiringDate = value;
					this.SendPropertyChanged("HiringDate");
					this.OnHiringDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoctorSpecialism", DbType="VarChar(50)")]
		public string DoctorSpecialism
		{
			get
			{
				return this._DoctorSpecialism;
			}
			set
			{
				if ((this._DoctorSpecialism != value))
				{
					this.OnDoctorSpecialismChanging(value);
					this.SendPropertyChanging();
					this._DoctorSpecialism = value;
					this.SendPropertyChanged("DoctorSpecialism");
					this.OnDoctorSpecialismChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Doctors_Appointments", Storage="_Appointments", ThisKey="DoctorId", OtherKey="DoctorId")]
		public EntitySet<Appointments> Appointments
		{
			get
			{
				return this._Appointments;
			}
			set
			{
				this._Appointments.Assign(value);
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
		
		private void attach_Appointments(Appointments entity)
		{
			this.SendPropertyChanging();
			entity.Doctors = this;
		}
		
		private void detach_Appointments(Appointments entity)
		{
			this.SendPropertyChanging();
			entity.Doctors = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Patient")]
	public partial class Patient : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PatientId;
		
		private string _PatientName;
		
		private string _PatientAddress;
		
		private System.Nullable<System.DateTime> _BirthDate;
		
		private System.Nullable<char> _PatientGender;
		
		private EntitySet<Appointments> _Appointments;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPatientIdChanging(int value);
    partial void OnPatientIdChanged();
    partial void OnPatientNameChanging(string value);
    partial void OnPatientNameChanged();
    partial void OnPatientAddressChanging(string value);
    partial void OnPatientAddressChanged();
    partial void OnBirthDateChanging(System.Nullable<System.DateTime> value);
    partial void OnBirthDateChanged();
    partial void OnPatientGenderChanging(System.Nullable<char> value);
    partial void OnPatientGenderChanged();
    #endregion
		
		public Patient()
		{
			this._Appointments = new EntitySet<Appointments>(new Action<Appointments>(this.attach_Appointments), new Action<Appointments>(this.detach_Appointments));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PatientId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int PatientId
		{
			get
			{
				return this._PatientId;
			}
			set
			{
				if ((this._PatientId != value))
				{
					this.OnPatientIdChanging(value);
					this.SendPropertyChanging();
					this._PatientId = value;
					this.SendPropertyChanged("PatientId");
					this.OnPatientIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PatientName", DbType="VarChar(50)")]
		public string PatientName
		{
			get
			{
				return this._PatientName;
			}
			set
			{
				if ((this._PatientName != value))
				{
					this.OnPatientNameChanging(value);
					this.SendPropertyChanging();
					this._PatientName = value;
					this.SendPropertyChanged("PatientName");
					this.OnPatientNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PatientAddress", DbType="VarChar(100)")]
		public string PatientAddress
		{
			get
			{
				return this._PatientAddress;
			}
			set
			{
				if ((this._PatientAddress != value))
				{
					this.OnPatientAddressChanging(value);
					this.SendPropertyChanging();
					this._PatientAddress = value;
					this.SendPropertyChanged("PatientAddress");
					this.OnPatientAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BirthDate", DbType="Date")]
		public System.Nullable<System.DateTime> BirthDate
		{
			get
			{
				return this._BirthDate;
			}
			set
			{
				if ((this._BirthDate != value))
				{
					this.OnBirthDateChanging(value);
					this.SendPropertyChanging();
					this._BirthDate = value;
					this.SendPropertyChanged("BirthDate");
					this.OnBirthDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PatientGender", DbType="Char(1)")]
		public System.Nullable<char> PatientGender
		{
			get
			{
				return this._PatientGender;
			}
			set
			{
				if ((this._PatientGender != value))
				{
					this.OnPatientGenderChanging(value);
					this.SendPropertyChanging();
					this._PatientGender = value;
					this.SendPropertyChanged("PatientGender");
					this.OnPatientGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Patient_Appointments", Storage="_Appointments", ThisKey="PatientId", OtherKey="PatientId")]
		public EntitySet<Appointments> Appointments
		{
			get
			{
				return this._Appointments;
			}
			set
			{
				this._Appointments.Assign(value);
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
		
		private void attach_Appointments(Appointments entity)
		{
			this.SendPropertyChanging();
			entity.Patient = this;
		}
		
		private void detach_Appointments(Appointments entity)
		{
			this.SendPropertyChanging();
			entity.Patient = null;
		}
	}
}
#pragma warning restore 1591
