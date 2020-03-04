Imports System
Imports DevExpress.Xpo
Namespace ServerModeGridProjects

	Public Class ServerSideGridTest
		Inherits XPBaseObject

		Private fOID As Integer
		<Key(True)>
		Public Property OID() As Integer
			Get
				Return fOID
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue(Of Integer)("OID", fOID, value)
			End Set
		End Property
		Private fSubject As String
		Public Property Subject() As String
			Get
				Return fSubject
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("Subject", fSubject, value)
			End Set
		End Property
		Private fFrom As String
		Public Property From() As String
			Get
				Return fFrom
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("From", fFrom, value)
			End Set
		End Property
		Private fSent As DateTime
		Public Property Sent() As DateTime
			Get
				Return fSent
			End Get
			Set(ByVal value As DateTime)
				SetPropertyValue(Of DateTime)("Sent", fSent, value)
			End Set
		End Property
		Private fSize As Long
		Public Property Size() As Long
			Get
				Return fSize
			End Get
			Set(ByVal value As Long)
				SetPropertyValue(Of Long)("Size", fSize, value)
			End Set
		End Property
		Private fHasAttachment As Boolean
		Public Property HasAttachment() As Boolean
			Get
				Return fHasAttachment
			End Get
			Set(ByVal value As Boolean)
				SetPropertyValue(Of Boolean)("HasAttachment", fHasAttachment, value)
			End Set
		End Property
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public Sub New()
			MyBase.New(Session.DefaultSession)
		End Sub
		Public Overrides Sub AfterConstruction()
			MyBase.AfterConstruction()
		End Sub
	End Class

End Namespace
