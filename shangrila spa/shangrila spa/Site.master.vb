Public Class SiteMaster
    Inherits System.Web.UI.MasterPage
    
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Protected Sub LoggedInMenuMenu_ItemClick(ByVal source As Object, ByVal e As DevExpress.Web.Bootstrap.BootstrapMenuItemEventArgs)
            If e.Item.Name = "Logout" Then
                            Dim AuthenticationManager = HttpContext.Current.GetOwinContext().Authentication
                AuthenticationManager.SignOut()

                Response.Redirect("~/Account/Login.aspx")
            End If
        End Sub


End Class