Module modUCController
    'MIS
    Public Sub toPanelMIS(width As Integer, height As Integer, control As Control)
        control.SetBounds((frmMISPanel.panelMIS.Width - width) / 2, (frmMISPanel.panelMIS.Width - width) / 2, width, height)
        frmMISPanel.panelMIS.Controls.Clear()
        frmMISPanel.panelMIS.Controls.Add(control)
    End Sub

    'Accounting
    Public Sub toPanelAccounting(width As Integer, height As Integer, control As Control)
        control.SetBounds((frmAccountingPanel.panelMIS.Width - width) / 2, (frmMISPanel.panelMIS.Width - width) / 2, width, height)
        frmAccountingPanel.panelMIS.Controls.Clear()
        frmAccountingPanel.panelMIS.Controls.Add(control)
    End Sub

    'Sales
    Public Sub toPanelSales(width As Integer, height As Integer, control As Control)
        control.SetBounds((frmSalesPanel.panelMIS.Width - width) / 2, (frmMISPanel.panelMIS.Width - width) / 2, width, height)
        frmSalesPanel.panelMIS.Controls.Clear()
        frmSalesPanel.panelMIS.Controls.Add(control)
    End Sub

    'HR
    Public Sub toPanelHR(width As Integer, height As Integer, control As Control)
        control.SetBounds((frmHRPanel.panelMIS.Width - width) / 2, (frmMISPanel.panelMIS.Width - width) / 2, width, height)
        frmHRPanel.panelMIS.Controls.Clear()
        frmHRPanel.panelMIS.Controls.Add(control)
    End Sub
End Module
