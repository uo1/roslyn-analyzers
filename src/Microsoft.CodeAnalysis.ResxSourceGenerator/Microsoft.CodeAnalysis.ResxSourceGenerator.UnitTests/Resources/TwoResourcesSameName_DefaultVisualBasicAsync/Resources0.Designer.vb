﻿' <auto-generated/>

Imports System.Reflection


Namespace Global.TestProject.Second
    ''' <summary>
    '''   A strongly-typed resource class, for looking up localized strings, etc.
    ''' </summary>
    Friend Partial Class Resources
        Private Sub New
        End Sub
        
        Private Shared s_resourceManager As Global.System.Resources.ResourceManager
        ''' <summary>
        '''   Returns the cached ResourceManager instance used by this class.
        ''' </summary>
        Public Shared ReadOnly Property ResourceManager As Global.System.Resources.ResourceManager
            Get
                If s_resourceManager Is Nothing Then
                    s_resourceManager = New Global.System.Resources.ResourceManager(GetType(Resources))
                End If
                Return s_resourceManager
            End Get
        End Property
        ''' <summary>
        '''   Overrides the current thread's CurrentUICulture property for all
        '''   resource lookups using this strongly typed resource class.
        ''' </summary>
        Public Shared Property Culture As Global.System.Globalization.CultureInfo
        <Global.System.Runtime.CompilerServices.MethodImpl(Global.System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)>
        Friend Shared Function GetResourceString(ByVal resourceKey As String, Optional ByVal defaultValue As String = Nothing) As String
            Return ResourceManager.GetString(resourceKey, Culture)
        End Function
        ''' <summary>value</summary>
        Public Shared ReadOnly Property [Name] As String
          Get
            Return GetResourceString("Name")
          End Get
        End Property

    End Class
End Namespace
