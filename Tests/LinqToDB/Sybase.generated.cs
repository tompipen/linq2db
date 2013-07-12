﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by T4Model template for T4 (https://github.com/linq2db/t4models).
//    Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data;

using LinqToDB;
using LinqToDB.Common;
using LinqToDB.Data;
using LinqToDB.Mapping;

namespace SybaseDataContext
{
	/// <summary>
	/// Database       : TestData
	/// Data Source    : DBHost2008
	/// Server Version : 15.7.0
	/// </summary>
	public partial class TestDataDB : LinqToDB.Data.DataConnection
	{
		public ITable<AllType>        AllTypes        { get { return this.GetTable<AllType>(); } }
		public ITable<BinaryData>     BinaryDatas     { get { return this.GetTable<BinaryData>(); } }
		public ITable<Child>          Children        { get { return this.GetTable<Child>(); } }
		public ITable<DataTypeTest>   DataTypeTests   { get { return this.GetTable<DataTypeTest>(); } }
		public ITable<Doctor>         Doctors         { get { return this.GetTable<Doctor>(); } }
		public ITable<GrandChild>     GrandChilds     { get { return this.GetTable<GrandChild>(); } }
		public ITable<LinqDataType>   LinqDataTypes   { get { return this.GetTable<LinqDataType>(); } }
		public ITable<Parent>         Parents         { get { return this.GetTable<Parent>(); } }
		public ITable<Patient>        Patients        { get { return this.GetTable<Patient>(); } }
		public ITable<Person>         People          { get { return this.GetTable<Person>(); } }
		public ITable<SysObject>      SysObjects      { get { return this.GetTable<SysObject>(); } }
		public ITable<sysquerymetric> sysquerymetrics { get { return this.GetTable<sysquerymetric>(); } }
		public ITable<TestIdentity>   TestIdentities  { get { return this.GetTable<TestIdentity>(); } }

		public TestDataDB()
		{
		}

		public TestDataDB(string configuration)
			: base(configuration)
		{
		}
	}

	[Table("AllTypes")]
	public partial class AllType
	{
		[Identity                                             ] public int      ID                    { get; set; } // int
		[Column,                                       NotNull] public long     bigintDataType        { get; set; } // bigint
		[Column,                                       NotNull] public object   uBigintDataType       { get; set; } // ubigint
		[Column,                                       NotNull] public decimal  numericDataType       { get; set; } // numeric(18, 0)
		[Column,                                       NotNull] public bool     bitDataType           { get; set; } // bit
		[Column,                                       NotNull] public short    smallintDataType      { get; set; } // smallint
		[Column,                                       NotNull] public object   uSmallintDataType     { get; set; } // usmallint
		[Column,                                       NotNull] public decimal  decimalDataType       { get; set; } // decimal(18, 0)
		[Column,                                       NotNull] public decimal  smallmoneyDataType    { get; set; } // smallmoney
		[Column,                                       NotNull] public int      intDataType           { get; set; } // int
		[Column,                                       NotNull] public object   uIntDataType          { get; set; } // uint
		[Column,                                       NotNull] public sbyte    tinyintDataType       { get; set; } // tinyint
		[Column,                                       NotNull] public decimal  moneyDataType         { get; set; } // money
		[Column,                                       NotNull] public double   floatDataType         { get; set; } // float
		[Column,                                       NotNull] public float    realDataType          { get; set; } // real
		[Column,                                       NotNull] public DateTime datetimeDataType      { get; set; } // datetime
		[Column,                                       NotNull] public DateTime smalldatetimeDataType { get; set; } // smalldatetime
		[Column,                                       NotNull] public object   dateDataType          { get; set; } // date
		[Column,                                       NotNull] public object   timeDataType          { get; set; } // time
		[Column,                                       NotNull] public string   charDataType          { get; set; } // char(1)
		[Column,                                       NotNull] public string   varcharDataType       { get; set; } // varchar(20)
		[Column,                                       NotNull] public string   textDataType          { get; set; } // text
		[Column,                                       NotNull] public string   ncharDataType         { get; set; } // nchar(20)
		[Column,                                       NotNull] public string   nvarcharDataType      { get; set; } // nvarchar(20)
		[Column,                                       NotNull] public object   ntextDataType         { get; set; } // unitext
		[Column,                                       NotNull] public byte[]   binaryDataType        { get; set; } // binary(1)
		[Column,                                       NotNull] public byte[]   varbinaryDataType     { get; set; } // varbinary(1)
		[Column,                                       NotNull] public byte[]   imageDataType         { get; set; } // image
		[Column(SkipOnInsert=true, SkipOnUpdate=true), NotNull] public byte[]   timestampDataType     { get; set; } // timestamp
	}

	[Table("BinaryData")]
	public partial class BinaryData
	{
		[PrimaryKey,                                   Identity] public int    BinaryDataID { get; set; } // int
		[Column(SkipOnInsert=true, SkipOnUpdate=true), NotNull ] public byte[] Stamp        { get; set; } // timestamp
		[Column,                                       NotNull ] public byte[] Data         { get; set; } // varbinary(1024)
	}

	[Table("Child")]
	public partial class Child
	{
		[Column, NotNull] public int ParentID { get; set; } // int
		[Column, NotNull] public int ChildID  { get; set; } // int
	}

	[Table("DataTypeTest")]
	public partial class DataTypeTest
	{
		[PrimaryKey, Identity] public int      DataTypeID { get; set; } // int
		[Column,     NotNull ] public byte[]   Binary_    { get; set; } // binary(50)
		[Column,     NotNull ] public bool     Boolean_   { get; set; } // bit
		[Column,     NotNull ] public sbyte    Byte_      { get; set; } // tinyint
		[Column,     NotNull ] public byte[]   Bytes_     { get; set; } // varbinary(50)
		[Column,     NotNull ] public string   Char_      { get; set; } // char(1)
		[Column,     NotNull ] public DateTime DateTime_  { get; set; } // datetime
		[Column,     NotNull ] public decimal  Decimal_   { get; set; } // decimal(20, 2)
		[Column,     NotNull ] public double   Double_    { get; set; } // float
		[Column,     NotNull ] public byte[]   Guid_      { get; set; } // varbinary(16)
		[Column,     NotNull ] public short    Int16_     { get; set; } // smallint
		[Column,     NotNull ] public int      Int32_     { get; set; } // int
		[Column,     NotNull ] public long     Int64_     { get; set; } // bigint
		[Column,     NotNull ] public decimal  Money_     { get; set; } // money
		[Column,     NotNull ] public sbyte    SByte_     { get; set; } // tinyint
		[Column,     NotNull ] public float    Single_    { get; set; } // real
		[Column,     NotNull ] public byte[]   Stream_    { get; set; } // varbinary(50)
		[Column,     NotNull ] public string   String_    { get; set; } // nvarchar(50)
		[Column,     NotNull ] public short    UInt16_    { get; set; } // smallint
		[Column,     NotNull ] public int      UInt32_    { get; set; } // int
		[Column,     NotNull ] public long     UInt64_    { get; set; } // bigint
		[Column,     NotNull ] public string   Xml_       { get; set; } // nvarchar(1000)
	}

	[Table("Doctor")]
	public partial class Doctor
	{
		[PrimaryKey, NotNull] public int    PersonID { get; set; } // int
		[Column,     NotNull] public string Taxonomy { get; set; } // nvarchar(50)

		#region Associations

		/// <summary>
		/// FK_Doctor_Person
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=false)]
		public Person Person { get; set; }

		#endregion
	}

	[Table("GrandChild")]
	public partial class GrandChild
	{
		[Column, NotNull] public int ParentID     { get; set; } // int
		[Column, NotNull] public int ChildID      { get; set; } // int
		[Column, NotNull] public int GrandChildID { get; set; } // int
	}

	[Table("LinqDataTypes")]
	public partial class LinqDataType
	{
		[Column, NotNull] public int      ID             { get; set; } // int
		[Column, NotNull] public decimal  MoneyValue     { get; set; } // decimal(10, 4)
		[Column, NotNull] public DateTime DateTimeValue  { get; set; } // datetime
		[Column, NotNull] public DateTime DateTimeValue2 { get; set; } // datetime
		[Column, NotNull] public bool     BoolValue      { get; set; } // bit
		[Column, NotNull] public string   GuidValue      { get; set; } // char(36)
		[Column, NotNull] public byte[]   BinaryValue    { get; set; } // binary(500)
		[Column, NotNull] public short    SmallIntValue  { get; set; } // smallint
		[Column, NotNull] public int      IntValue       { get; set; } // int
		[Column, NotNull] public long     BigIntValue    { get; set; } // bigint
	}

	[Table("Parent")]
	public partial class Parent
	{
		[Column, NotNull] public int ParentID { get; set; } // int
		[Column, NotNull] public int Value1   { get; set; } // int
	}

	[Table("Patient")]
	public partial class Patient
	{
		[PrimaryKey, NotNull] public int    PersonID  { get; set; } // int
		[Column,     NotNull] public string Diagnosis { get; set; } // nvarchar(256)

		#region Associations

		/// <summary>
		/// FK_Patient_Person
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=false)]
		public Person Person { get; set; }

		#endregion
	}

	[Table("Person")]
	public partial class Person
	{
		[PrimaryKey, Identity] public int    PersonID   { get; set; } // int
		[Column,     NotNull ] public string FirstName  { get; set; } // nvarchar(50)
		[Column,     NotNull ] public string LastName   { get; set; } // nvarchar(50)
		[Column,     NotNull ] public string MiddleName { get; set; } // nvarchar(50)
		[Column,     NotNull ] public string Gender     { get; set; } // char(1)

		#region Associations

		/// <summary>
		/// FK_Doctor_Person_BackReference
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=false)]
		public Doctor Doctor { get; set; }

		/// <summary>
		/// FK_Patient_Person_BackReference
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=false)]
		public Patient Patient { get; set; }

		#endregion
	}

	[Table("sysobjects")]
	public partial class SysObject
	{
		[Column, NotNull    ] public string   name      { get; set; } // varchar
		[Column, NotNull    ] public int      id        { get; set; } // int
		[Column, NotNull    ] public int      uid       { get; set; } // int
		[Column, NotNull    ] public string   type      { get; set; } // char
		[Column, NotNull    ] public short    userstat  { get; set; } // smallint
		[Column, NotNull    ] public short    sysstat   { get; set; } // smallint
		[Column, NotNull    ] public short    indexdel  { get; set; } // smallint
		[Column, NotNull    ] public short    schemacnt { get; set; } // smallint
		[Column, NotNull    ] public int      sysstat2  { get; set; } // int
		[Column, NotNull    ] public DateTime crdate    { get; set; } // datetime
		[Column, NotNull    ] public DateTime expdate   { get; set; } // datetime
		[Column, NotNull    ] public int      deltrig   { get; set; } // int
		[Column, NotNull    ] public int      instrig   { get; set; } // int
		[Column, NotNull    ] public int      updtrig   { get; set; } // int
		[Column, NotNull    ] public int      seltrig   { get; set; } // int
		[Column, NotNull    ] public int      ckfirst   { get; set; } // int
		[Column, NotNull    ] public short    cache     { get; set; } // smallint
		[Column,    Nullable] public int      audflags  { get; set; } // int
		[Column, NotNull    ] public int      objspare  { get; set; } // int
		[Column,    Nullable] public byte[]   versionts { get; set; } // binary
		[Column, NotNull    ] public string   loginame  { get; set; } // varchar
	}

	// View
	[Table("sysquerymetrics")]
	public partial class sysquerymetric
	{
		[Column, NotNull] public int    uid       { get; set; } // int
		[Column, NotNull] public int    gid       { get; set; } // int
		[Column, NotNull] public int    hashkey   { get; set; } // int
		[Column, NotNull] public int    id        { get; set; } // int
		[Column, NotNull] public short  sequence  { get; set; } // smallint
		[Column, NotNull] public int    exec_min  { get; set; } // int
		[Column, NotNull] public int    exec_max  { get; set; } // int
		[Column, NotNull] public int    exec_avg  { get; set; } // int
		[Column, NotNull] public int    elap_min  { get; set; } // int
		[Column, NotNull] public int    elap_max  { get; set; } // int
		[Column, NotNull] public int    elap_avg  { get; set; } // int
		[Column, NotNull] public int    lio_min   { get; set; } // int
		[Column, NotNull] public int    lio_max   { get; set; } // int
		[Column, NotNull] public int    lio_avg   { get; set; } // int
		[Column, NotNull] public int    pio_min   { get; set; } // int
		[Column, NotNull] public int    pio_max   { get; set; } // int
		[Column, NotNull] public int    pio_avg   { get; set; } // int
		[Column, NotNull] public int    cnt       { get; set; } // int
		[Column, NotNull] public int    abort_cnt { get; set; } // int
		[Column, NotNull] public string qtext     { get; set; } // varchar(255)
	}

	[Table("TestIdentity")]
	public partial class TestIdentity
	{
		[PrimaryKey, Identity] public int ID { get; set; } // int
	}

	public static partial class TestDataDBStoredProcedures
	{
		#region OutRefEnumTest

		public static int OutRefEnumTest(this DataConnection dataConnection, string str, out string outputStr, out string inputOutputStr)
		{
			var ret = dataConnection.ExecuteProc("[OutRefEnumTest]",
				new DataParameter("str", str));

			outputStr      = Converter.ChangeTypeTo<string>(((IDbDataParameter)dataConnection.Command.Parameters["outputStr"]).     Value);
			inputOutputStr = Converter.ChangeTypeTo<string>(((IDbDataParameter)dataConnection.Command.Parameters["inputOutputStr"]).Value);

			return ret;
		}

		#endregion

		#region OutRefTest

		public static int OutRefTest(this DataConnection dataConnection, int? ID, out int? outputID, out int? inputOutputID, string str, out string outputStr, out string inputOutputStr)
		{
			var ret = dataConnection.ExecuteProc("[OutRefTest]",
				new DataParameter("ID",  ID),
				new DataParameter("str", str));

			outputID       = Converter.ChangeTypeTo<int?>  (((IDbDataParameter)dataConnection.Command.Parameters["outputID"]).      Value);
			inputOutputID  = Converter.ChangeTypeTo<int?>  (((IDbDataParameter)dataConnection.Command.Parameters["inputOutputID"]). Value);
			outputStr      = Converter.ChangeTypeTo<string>(((IDbDataParameter)dataConnection.Command.Parameters["outputStr"]).     Value);
			inputOutputStr = Converter.ChangeTypeTo<string>(((IDbDataParameter)dataConnection.Command.Parameters["inputOutputStr"]).Value);

			return ret;
		}

		#endregion

		#region Patient_SelectAll

		public partial class Patient_SelectAllResult
		{
			public int    PersonID   { get; set; }
			public string FirstName  { get; set; }
			public string LastName   { get; set; }
			public string MiddleName { get; set; }
			public string Gender     { get; set; }
			public string Diagnosis  { get; set; }
		}

		public static IEnumerable<Patient_SelectAllResult> Patient_SelectAll(this DataConnection dataConnection)
		{
			return dataConnection.QueryProc<Patient_SelectAllResult>("[Patient_SelectAll]");
		}

		#endregion

		#region Patient_SelectByName

		public partial class Patient_SelectByNameResult
		{
			public int    PersonID   { get; set; }
			public string FirstName  { get; set; }
			public string LastName   { get; set; }
			public string MiddleName { get; set; }
			public string Gender     { get; set; }
			public string Diagnosis  { get; set; }
		}

		public static IEnumerable<Patient_SelectByNameResult> Patient_SelectByName(this DataConnection dataConnection, string firstName, string lastName)
		{
			return dataConnection.QueryProc<Patient_SelectByNameResult>("[Patient_SelectByName]",
				new DataParameter("firstName", firstName),
				new DataParameter("lastName",  lastName));
		}

		#endregion

		#region Person_Delete

		public static int Person_Delete(this DataConnection dataConnection, int? PersonID)
		{
			return dataConnection.ExecuteProc("[Person_Delete]",
				new DataParameter("PersonID", PersonID));
		}

		#endregion

		#region Person_Insert

		public partial class Person_InsertResult
		{
			public int? PersonID { get; set; }
		}

		public static IEnumerable<Person_InsertResult> Person_Insert(this DataConnection dataConnection, string FirstName, string LastName, string MiddleName, string Gender)
		{
			return dataConnection.QueryProc<Person_InsertResult>("[Person_Insert]",
				new DataParameter("FirstName",  FirstName),
				new DataParameter("LastName",   LastName),
				new DataParameter("MiddleName", MiddleName),
				new DataParameter("Gender",     Gender));
		}

		#endregion

		#region Person_Insert_OutputParameter

		public static int Person_Insert_OutputParameter(this DataConnection dataConnection, string FirstName, string LastName, string MiddleName, string Gender, out int? PersonID)
		{
			var ret = dataConnection.ExecuteProc("Person_Insert_OutputParameter",
				new DataParameter("FirstName",  FirstName),
				new DataParameter("LastName",   LastName),
				new DataParameter("MiddleName", MiddleName),
				new DataParameter("Gender",     Gender));

			PersonID = Converter.ChangeTypeTo<int?>(((IDbDataParameter)dataConnection.Command.Parameters["PersonID"]).Value);

			return ret;
		}

		#endregion

		#region Person_SelectAll

		public static IEnumerable<Person> Person_SelectAll(this DataConnection dataConnection)
		{
			return dataConnection.QueryProc<Person>("[Person_SelectAll]");
		}

		#endregion

		#region Person_SelectByKey

		public static IEnumerable<Person> Person_SelectByKey(this DataConnection dataConnection, int? id)
		{
			return dataConnection.QueryProc<Person>("[Person_SelectByKey]",
				new DataParameter("id", id));
		}

		#endregion

		#region Person_SelectByName

		public static IEnumerable<Person> Person_SelectByName(this DataConnection dataConnection, string firstName, string lastName)
		{
			return dataConnection.QueryProc<Person>("[Person_SelectByName]",
				new DataParameter("firstName", firstName),
				new DataParameter("lastName",  lastName));
		}

		#endregion

		#region Person_SelectListByName

		public static IEnumerable<Person> Person_SelectListByName(this DataConnection dataConnection, string firstName, string lastName)
		{
			return dataConnection.QueryProc<Person>("[Person_SelectListByName]",
				new DataParameter("firstName", firstName),
				new DataParameter("lastName",  lastName));
		}

		#endregion

		#region Person_Update

		public static int Person_Update(this DataConnection dataConnection, int? PersonID, string FirstName, string LastName, string MiddleName, string Gender)
		{
			return dataConnection.ExecuteProc("[Person_Update]",
				new DataParameter("PersonID",   PersonID),
				new DataParameter("FirstName",  FirstName),
				new DataParameter("LastName",   LastName),
				new DataParameter("MiddleName", MiddleName),
				new DataParameter("Gender",     Gender));
		}

		#endregion

		#region Scalar_DataReader

		public partial class Scalar_DataReaderResult
		{
			public int    intField    { get; set; }
			public string stringField { get; set; }
		}

		public static IEnumerable<Scalar_DataReaderResult> Scalar_DataReader(this DataConnection dataConnection)
		{
			return dataConnection.QueryProc<Scalar_DataReaderResult>("[Scalar_DataReader]");
		}

		#endregion

		#region Scalar_OutputParameter

		public static int Scalar_OutputParameter(this DataConnection dataConnection, out int? outputInt, out string outputString)
		{
			var ret = dataConnection.ExecuteProc("[Scalar_OutputParameter]");

			outputInt    = Converter.ChangeTypeTo<int?>  (((IDbDataParameter)dataConnection.Command.Parameters["outputInt"]).   Value);
			outputString = Converter.ChangeTypeTo<string>(((IDbDataParameter)dataConnection.Command.Parameters["outputString"]).Value);

			return ret;
		}

		#endregion

		#region Scalar_ReturnParameterWithObject

		public static IEnumerable<Person> Scalar_ReturnParameterWithObject(this DataConnection dataConnection, int? id)
		{
			return dataConnection.QueryProc<Person>("Scalar_ReturnParameterWithObject",
				new DataParameter("id", id));
		}

		#endregion
	}
}