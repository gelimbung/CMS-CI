Public Class MainForm
    Private Sub ProductToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItemProduct.Click
        CloseAll()
        Dim prodFrm As New FormProduct
        prodFrm.Show()
        prodFrm.MdiParent = Me
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SupplierToolStripMenuItem.Click
        CloseAll()
        Dim suppForm As New FormSupplier
        suppForm.Show()
        suppForm.MdiParent = Me
    End Sub



    Private Sub CloseAll()
        For Each child As Form In MdiChildren
            child.Close()
        Next
    End Sub

    Private Sub RuangToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RuangToolStripMenuItem.Click
        CloseAll()
        Dim roomFrm As New FormRoom
        roomFrm.Show()
        roomFrm.MdiParent = Me
    End Sub


    Private Sub ToolStripMenuItemUom_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItemUom.Click
        CloseAll()
        Dim uomFrm As New FormUom
        uomFrm.Show()
        uomFrm.MdiParent = Me
    End Sub

    Private Sub ItemMasukToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ItemMasukToolStripMenuItem.Click
        CloseAll()
        Dim orderFrm As New FormOrder
        orderFrm.Show()
        orderFrm.MdiParent = Me
    End Sub

    Private Sub ItemKeluarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ItemKeluarToolStripMenuItem.Click
        CloseAll()
        Dim deliverForm As New FormDeliver()
        deliverForm.Show()
        deliverForm.MdiParent = Me
    End Sub

    Private Sub DistribusiBarangToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DistribusiBarangToolStripMenuItem.Click
        Dim rptFrm As New FormLaporanItemMasuk()
        rptFrm.MdiParent = Me
        rptFrm.Show()
    End Sub

    Private Sub BarungMasukToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BarungMasukToolStripMenuItem.Click
        Dim rptFrm As New FormLaporanItemKeluar()
        rptFrm.MdiParent = Me
        rptFrm.Show()
    End Sub

    Private Sub PersediaanToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PersediaanToolStripMenuItem.Click
        Dim rptFrm As New FormLaporanItemPersediaan()
        rptFrm.MdiParent = Me
        rptFrm.Show()
    End Sub

   
    Private Sub ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Dim returFrm As New FormRetur()
        returFrm.MdiParent = Me
        returFrm.Show()
    End Sub
End Class
