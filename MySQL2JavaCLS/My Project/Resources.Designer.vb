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
        '''	
        '''	//////////////////////////////[ CONSTRUCTOR ]//////////////////////////////
        '''	// Create a @CLASSNAME@ object from the given @PRIMARYKEY@. //
        '''	///////////////////////////////////////////////////////////////////////////
        '''
        '''	/// DEFAULT CONSTRUCTOR ///
        '''	/**
        '''         * Default @CLASSNAME@ class to use a private helpful methods.
        '''         */
        '''	public @CLASSNAME@() {}
        '''
        '''	/// OVERLOAD CONSTRUCTOR ///
        '''	/**
        '''         * 
        '''         * @param @CLASSNAME@_@PRIMARYKEY@ A Primary key of @CLASSNAM [rest of string was truncated]&quot;;.
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
        '''/*********************************************{{{ CLASS START }}}*********************************************/
        '''/**
        '''* @CLASSNAME@ class to manage @CLASSNAME@ in the Database.
        '''*/
        '''public class @CLASSNAME@ {
        '''
        '''@SECTIONSTART@
        '''	
        '''	/// PRIVATE PROPERTIES ///
        '''@CLASSHEADER_PRIVATE_PROPERTIES@
        '''	
        '''	/// PUBLIC PROPERTIES ///
        '''	public final String relName = &quot;@CLASSHEADER_TABLENAME@&quot;;
        '''	public final String columnNames = &quot;&quot;
        '''@ [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property JAVAforMYSQL_ClassHeader() As String
            Get
                Return ResourceManager.GetString("JAVAforMYSQL_ClassHeader", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to @SECTIONSTART@
        '''
        '''	/// GET ///
        '''@GET_PROPERTIYLIST@
        '''
        '''	/// SET ///
        '''@SET_PROPERTYLIST@
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
        '''  Looks up a localized string similar to /////////////////////////////////////////////////////////////////////
        '''////////////////////// THIS CLASS GENERATED BY //////////////////////
        '''////////////////////// MySQL2JavaCLS Generator //////////////////////
        '''/////////////////////////////////////////////////////////////////////
        '''/*************** Created by feinz(feineirz@live.com) ***************/
        '''/////////////////////////////////////////////////////////////////////
        '''.
        '''</summary>
        Friend ReadOnly Property JAVAforMYSQL_Credits() As String
            Get
                Return ResourceManager.GetString("JAVAforMYSQL_Credits", resourceCulture)
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
        '''			Class.forName(&quot;com.@MySQLVersionShift@.jdbc.Driver&quot;);  
        '''			conn = DriverManager.getConnection(
        '''					&quot;jdbc:mysql://@HOST@:@PORT@/@DATABASE@&quot;
        '''					+ &quot;?useJDBCCompliantTimezoneShift=@useJDBCCompliantTimezoneShiftOption@&quot;
        '''					+ &quot;&amp;useLegacyDatetimeCode=@useLegacyDatetimeCodeOption@&quot;
        '''					+ &quot;&amp;useSSL=@useSSLOption@&quot;
        '''					+ &quot;&amp;au [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property JAVAforMYSQL_MySQLDBConnector() As String
            Get
                Return ResourceManager.GetString("JAVAforMYSQL_MySQLDBConnector", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 	//////////////////////////////[ Add ]//////////////////////////////
        '''	// Add @CLASSNAME@ to database by giving a raw information. //
        '''	///////////////////////////////////////////////////////////////////
        '''	/**
        '''         * 
        '''         * @return @CLASSNAME@ object of new created @CLASSNAME@.
        '''         */
        '''	public static @CLASSNAME@ add@CLASSNAME@(@COLUMNLIST_WITHDATATYPE@) {
        '''		
        '''		@CLASSNAME@Info @CLASSNAMELOWER@Info = new @CLASSNAME@Info();
        '''@STRUCTURED_COLUMNLIST@
        '''		
        '''		return add@CLASSNAME@(@CLASSNAMELOWE [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property JAVAforMYSQL_REQFUNC_Add() As String
            Get
                Return ResourceManager.GetString("JAVAforMYSQL_REQFUNC_Add", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 	//////////////////////////////[ Delete ]//////////////////////////////
        '''	// Delete @CLASSNAME@ from database. //
        '''	//////////////////////////////////////////////////////////////////////
        '''	/**
        '''         * 
        '''         * @return True if deletion successful.
        '''         */
        '''	private boolean delete@CLASSNAME@() {
        '''		
        '''		return delete@CLASSNAME@(this.@PRIMARYKEY@);
        '''		
        '''	} ////////////////////////////////////////////////////////////////////
        '''	/**
        '''         * 
        '''         * @param @PRIMARYKEY@ @CLASSNAME@ @PRIMARYKEY@ [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property JAVAforMYSQL_REQFUNC_Delete() As String
            Get
                Return ResourceManager.GetString("JAVAforMYSQL_REQFUNC_Delete", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 	//////////////////////////////[ IsExist ]//////////////////////////////
        '''	// Check if record(s) from the given condition is exist in a database. //
        '''	///////////////////////////////////////////////////////////////////////
        '''	/**
        '''         * 
        '''         * @param condition The condition to specify the record to be return.
        '''         * 
        '''         *  Ex. &quot;name = &apos;Foo&apos; AND date BETWEEN &apos;2021-01-01&apos; AND &apos;2021-12-31&apos;&quot;
        '''         * 
        '''         * @return The first @CLASSNAME@ object matches the given condition.
        '''        [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property JAVAforMYSQL_REQFUNC_IsExist() As String
            Get
                Return ResourceManager.GetString("JAVAforMYSQL_REQFUNC_IsExist", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 	//////////////////////////////[ List ]//////////////////////////////
        '''	// List @CLASSNAME@ in database as @CLASSNAME@ objects. //
        '''	////////////////////////////////////////////////////////////////////
        '''	/// Overload ///
        '''	/**
        '''         * 
        '''         * Default List method to list all record of @CLASSNAME@ in the database.
        '''         * 
        '''         * @return ArrayList of @CLASSNAME@ objects.
        '''         * 
        '''         */
        '''	public static ArrayList&lt;@CLASSNAME@&gt; list@CLASSNAME@(){
        '''		return list@CLASSNAME@(&quot;&quot;,&quot;&quot;);
        '''	}        ''' [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property JAVAforMYSQL_REQFUNC_List() As String
            Get
                Return ResourceManager.GetString("JAVAforMYSQL_REQFUNC_List", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to     //////////////////////////////[ to@CLASSNAME@Info ]//////////////////////////////
        '''    // Convert @CLASSNAME@ class to the @CLASSNAME@Info class. //
        '''    ///////////////////////////////////////////////////////////////////////
        '''    private UserInfo @CLASSNAME@Info to@CLASSNAME@Info() {
        '''        
        '''        ci = new @CLASSNAME@Info();
        '''
        '''        @TOCLASSINFO_CONVERTLIST@
        '''
        '''        return ci;                    
        '''
        '''    } /////////////////////////////////////////////////////////////////////.
        '''</summary>
        Friend ReadOnly Property JAVAforMYSQL_REQFUNC_ToClassInfo() As String
            Get
                Return ResourceManager.GetString("JAVAforMYSQL_REQFUNC_ToClassInfo", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 	//////////////////////////////////[ Update ]/////////////////////////////////
        '''	// Update @CLASSNAME@ information in database by giving a raw information. //
        '''	/////////////////////////////////////////////////////////////////////////////
        '''	/**
        '''         * 
        '''         * @return True if update successful.
        '''         */
        '''	public static boolean update@CLASSNAME@Info(@COLUMNLIST_WITHDATATYPE@) {
        '''		
        '''		@CLASSNAME@Info @CLASSNAMELOWER@Info = new @CLASSNAME@Info();
        '''@STRUCTURED_COLUMNLIST@
        '''		
        '''		return update@CLAS [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property JAVAforMYSQL_REQFUNC_Update() As String
            Get
                Return ResourceManager.GetString("JAVAforMYSQL_REQFUNC_Update", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 
        '''
        '''@SECTIONSTART@
        '''
        '''// @USER CUSTOM FUNCTIONS@ //
        '''// PLACE YOUR CUSTOM FUNCTIONS HERE //
        '''
        '''@SECTIONEND@
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
