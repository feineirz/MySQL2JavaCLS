﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("MySQL2JavaCLS.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to @SECTIONSTART@
        '''
        '''	public @CLASSNAME@() {}
        '''	
        '''	// Create a @CLASSNAME@ object from the given @PRIMARYKEY@.
        '''	public @CLASSNAME@(@PRIMARYKEY_DATATYPE@ @CLASSNAME@_@PRIMARYKEY@) {
        '''		
        '''		Connection conn = new MySQLDBConnector().getDBConnection();
        '''		try {
        '''			String qry = &quot;SELECT *&quot;
        '''					+ &quot; FROM &quot; + relName
        '''					+ &quot; WHERE @PRIMARYKEY@=?&quot;;
        '''			PreparedStatement stmt = conn.prepareStatement(qry);
        '''			stmt.set@PRIMARYKEY_GETSETDATATYPE@(1, @CLASSNAME@_@PRIMARYKEY@);
        '''			
        '''			ResultSet rs = stmt.executeQuery( [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property JAVAforMYSQL_ClassConstructor() As String
            Get
                Return ResourceManager.GetString("JAVAforMYSQL_ClassConstructor", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to import java.sql.*;
        '''import java.util.*;
        '''import java.util.Date;
        '''import java.lang.*;
        '''
        '''////////////////////////////// CLASS START //////////////////////////////
        '''
        '''public class @CLASSNAME@ {
        '''
        '''@SECTIONSTART@
        '''	
        '''	// Private Properties //
        '''@CLASSHEADER_PRIVATE_PROPERTIES@
        '''	
        '''	// Public Properties //
        '''	public final String relName = &quot;@CLASSHEADER_TABLENAME@&quot;;
        '''	public final String columnNames = &quot;&quot;
        '''@CLASSHEADER_COLUMNLIST@;
        '''
        '''	// Class Structure //
        '''	public static class @CLASSNAME@Info {
        '''@CLASSHEADER_STRU [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property JAVAforMYSQL_ClassHeader() As String
            Get
                Return ResourceManager.GetString("JAVAforMYSQL_ClassHeader", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to @SECTIONSTART@
        '''
        '''@GET_PROPERTIYLIST@
        '''
        '''@SECTIONEND@
        '''
        '''.
        '''</summary>
        Friend ReadOnly Property JAVAforMYSQL_ClassProperties() As String
            Get
                Return ResourceManager.GetString("JAVAforMYSQL_ClassProperties", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to import java.sql.*;
        '''
        '''public class MySQLDBConnector {
        '''	
        '''	public Connection conn = null;
        '''	
        '''	public MySQLDBConnector() {}
        '''	
        '''	public Connection getDBConnection() {
        '''		
        '''		try{
        '''			Class.forName(&quot;com.mysql.cj.jdbc.Driver&quot;);  
        '''			conn = DriverManager.getConnection(
        '''					&quot;jdbc:mysql://@HOST@:@PORT@/@DATABASE@&quot;
        '''					+ &quot;?useUnicode=true&quot;
        '''					+ &quot;&amp;useJDBCCompliantTimezoneShift=true&quot;
        '''					+ &quot;&amp;useLegacyDatetimeCode=false&amp;serverTimezone=UTC&quot;
        '''					+ &quot;&amp;autoReconnect=true&quot;
        '''					+ &quot;&amp;useSSL=false&quot;,
        '''					&quot;@USER [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property JAVAforMYSQL_MySQLDBConnector() As String
            Get
                Return ResourceManager.GetString("JAVAforMYSQL_MySQLDBConnector", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 	// Add //
        '''	// Add @CLASSNAME@ to database by giving a raw information.
        '''	public static boolean add@CLASSNAME@(@COLUMNLIST_WITHDATATYPE@) {
        '''		
        '''		@CLASSNAME@Info @CLASSNAMELOWER@Info = new @CLASSNAME@Info();
        '''@STRUCTURED_COLUMNLIST@
        '''		
        '''		return add@CLASSNAME@(@CLASSNAMELOWER@Info);
        '''		
        '''	}
        '''	
        '''	// Add @CLASSNAME@ to database by giving a structured information.
        '''	public static boolean add@CLASSNAME@(@CLASSNAME@Info @CLASSNAMELOWER@Info) {
        '''		
        '''		Connection conn = new MySQLDBConnector().getDBConnection(); [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property JAVAforMYSQL_REQFUNC_Add() As String
            Get
                Return ResourceManager.GetString("JAVAforMYSQL_REQFUNC_Add", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 	// Delete //
        '''	// Delete @CLASSNAME@ from a database.
        '''	public static boolean delete@CLASSNAME@(@PRIMARYKEY_DATATYPE@ @PRIMARYKEY@) {
        '''		
        '''		Connection conn = new MySQLDBConnector().getDBConnection();
        '''		try {
        '''			String qry = &quot;DELETE FROM @TABLENAME@&quot;
        '''					+ &quot; WHERE @PRIMARYKEY@=?&quot;;
        '''			PreparedStatement stmt = conn.prepareStatement(qry);
        '''			stmt.set@PRIMARYKEY_GETSETDATATYPE@(1, @PRIMARYKEY@);
        '''			
        '''			stmt.execute();			
        '''			conn.close();
        '''			return true;
        '''			
        '''		} catch (SQLException e) {
        '''			try {
        '''	 [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property JAVAforMYSQL_REQFUNC_Delete() As String
            Get
                Return ResourceManager.GetString("JAVAforMYSQL_REQFUNC_Delete", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 	// IsExist //
        '''	// Check if record(s) from the given condition is exist in a database.
        '''	public static boolean isExist(String condition) {
        '''		
        '''		Connection conn = new MySQLDBConnector().getDBConnection();
        '''		
        '''		if(condition != &quot;&quot;) condition = &quot; WHERE &quot; + condition;
        '''		try {
        '''			String qry = &quot;SELECT *&quot; 
        '''					+ &quot; FROM @TABLENAME@&quot;
        '''					+ condition;
        '''			Statement stmt = conn.createStatement();
        '''			ResultSet rs = stmt.executeQuery(qry);
        '''			while (rs.next()) {
        '''				conn.close();
        '''				return true;
        '''			}			        ''' [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property JAVAforMYSQL_REQFUNC_IsExist() As String
            Get
                Return ResourceManager.GetString("JAVAforMYSQL_REQFUNC_IsExist", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 	// List //
        '''	// List @CLASSNAME@ in database as a @CLASSNAME@ objects.
        '''	/// Overload ///
        '''	public static ArrayList&lt;@CLASSNAME@&gt; list@CLASSNAME@(){
        '''		return list@CLASSNAME@(&quot;&quot;,&quot;&quot;);
        '''	}
        '''	public static ArrayList&lt;@CLASSNAME@&gt; list@CLASSNAME@(String condition){
        '''		return list@CLASSNAME@(condition,&quot;&quot;);
        '''	}	
        '''	/// Main ///
        '''	public static ArrayList&lt;@CLASSNAME@&gt; list@CLASSNAME@(String condition, String order) {
        '''		
        '''		ArrayList&lt;@CLASSNAME@&gt; buff = new ArrayList&lt;@CLASSNAME@&gt;();
        '''		
        '''		if(condition != &quot;&quot;) conditi [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property JAVAforMYSQL_REQFUNC_List() As String
            Get
                Return ResourceManager.GetString("JAVAforMYSQL_REQFUNC_List", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 	// Update //
        '''	// Update @CLASSNAME@ information in database by giving a raw information.
        '''	public static boolean update@CLASSNAME@Info(@COLUMNLIST_WITHDATATYPE@) {
        '''		
        '''		@CLASSNAME@Info @CLASSNAMELOWER@Info = new @CLASSNAME@Info();
        '''@STRUCTURED_COLUMNLIST@
        '''		
        '''		return update@CLASSNAME@Info(@CLASSNAMELOWER@Info);
        '''		
        '''	}
        '''	
        '''	// Update @CLASSNAME@ information in database by giving a structured information.
        '''	public static boolean update@CLASSNAME@Info(@CLASSNAME@Info @CLASSNAMELOWER@Info) {
        '''		
        '''		Conne [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property JAVAforMYSQL_REQFUNC_Update() As String
            Get
                Return ResourceManager.GetString("JAVAforMYSQL_REQFUNC_Update", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 
        '''
        '''@USER CUSTOM FUNCTIONS@
        '''
        '''.
        '''</summary>
        Friend ReadOnly Property JAVAforMYSQL_UCFUNC() As String
            Get
                Return ResourceManager.GetString("JAVAforMYSQL_UCFUNC", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
