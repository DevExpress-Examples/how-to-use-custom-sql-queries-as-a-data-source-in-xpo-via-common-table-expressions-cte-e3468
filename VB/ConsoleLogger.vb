﻿Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.Xpo.Logger

Namespace S138124
	Public Class ConsoleLogger
		Implements ILogger
		#Region "ILogger Members"

		Public Sub ClearLog() Implements ILogger.ClearLog
		End Sub

		Public ReadOnly Property Count() As Integer Implements ILogger.Count
			Get
				Return 0
			End Get
		End Property

		Public Property Enabled() As Boolean Implements ILogger.Enabled
			Get
				Return True
			End Get
			Set(ByVal value As Boolean)
			End Set
		End Property

		Public Sub Log(ByVal message As LogMessage) Implements ILogger.Log
			If message.MessageType <> LogMessageType.DbCommand Then
				Return
			End If
			Console.WriteLine(message.MessageText)
		End Sub

		Public Property LogLimit() As Integer Implements ILogger.LogLimit
			Get
				Return Integer.MaxValue
			End Get
			Set(ByVal value As Integer)
			End Set
		End Property

		Public ReadOnly Property LostMessageCount() As Integer Implements ILogger.LostMessageCount
			Get
				Return 0
			End Get
		End Property

		Public ReadOnly Property ServerActive() As Boolean Implements ILogger.ServerActive
			Get
				Return True
			End Get
		End Property

		#End Region
	End Class
End Namespace
