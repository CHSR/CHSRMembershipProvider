Imports System
Imports System.Web.Security

Public Class CHsRMembershipUser
    Inherits MembershipUser

    Private _program As Integer

    Public Property program() As Integer
        Get
            Return _program
        End Get
        Set(ByVal value As Integer)
            _program = value
        End Set
    End Property

    Private _role As String

    Public Property Role() As String
        Get
            Return _role
        End Get
        Set(ByVal value As String)
            _role = value
        End Set
    End Property

    Public Sub New(ByVal providername As String, _
                   ByVal username As String, _
                   ByVal userid As Object, _
                   ByVal email As String, _
                   ByVal passwordQuestion As String, _
                   ByVal comment As String, _
                   ByVal isApproved As Boolean, _
                   ByVal isLockedOut As Boolean, _
                   ByVal creationDate As DateTime, _
                   ByVal lastLoginDate As DateTime, _
                   ByVal lastActivityDate As DateTime, _
                   ByVal lastPasswordChangedDate As DateTime, _
                   ByVal lastLockedOutDate As DateTime, _
                   ByVal program As Integer, _
                   ByVal role As String)

        MyBase.New(providername, _
                   username, _
                   userid, _
                   email, _
                   passwordQuestion, _
                   comment, _
                   isApproved, _
                   isLockedOut, _
                   creationDate, _
                   lastLoginDate, _
                   lastActivityDate, _
                   lastPasswordChangedDate, _
                   lastLockedOutDate)

        Me.program = program
        Me.Role = role

    End Sub

End Class

