Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class InputProduksiBarang
    Dim conn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand
    Dim rd As OleDbDataReader
    Dim str As String

    'Method Koneksi
    Sub Koneksi()
        ' Ganti path str sesuai dengan lokasi Connection String database.
        str = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Project\ProduksiBarang2\Database\dbbarang.mdb"
        conn = New OleDbConnection(str)
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub

    'Method TextMati
    Sub TextMati()
        Me.tbIdBarang.Enabled = False
        Me.tbNamaBarang.Enabled = False
        Me.dtpTglProduksi.Enabled = False
        Me.tbIdProduksi.Enabled = False
        Me.tbIdSuplier.Enabled = False
        Me.tbIdKaryawan.Enabled = False
        Me.tbStokBarang.Enabled = False
        Me.tbHargaBarang.Enabled = False

    End Sub

    'Method TextHidup
    Sub TextHidup()
        Me.tbIdBarang.Enabled = True
        Me.tbNamaBarang.Enabled = True
        Me.dtpTglProduksi.Enabled = True
        Me.tbIdProduksi.Enabled = True
        Me.tbIdSuplier.Enabled = True
        Me.tbIdKaryawan.Enabled = True
        Me.tbStokBarang.Enabled = True
        Me.tbHargaBarang.Enabled = True
    End Sub

    'Method Kosong
    Sub Kosong()
        Me.tbIdBarang.Clear()
        Me.tbNamaBarang.Clear()
        Me.tbIdProduksi.Clear()
        Me.tbIdSuplier.Clear()
        Me.tbIdKaryawan.Clear()
        Me.tbStokBarang.Clear()
        Me.tbHargaBarang.Clear()
        Me.tbIdBarang.Focus()
    End Sub

    Private Sub InputProduksiBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call Kosong()
        Call TextMati()
        'dgvDataBarang.ReadOnly = True   
        Me.btnTambah.Enabled = True
        Me.btnSimpan.Enabled = False
        Me.btnEdit.Enabled = False
        Me.btnUpdate.Enabled = False
        Me.btnBatal.Enabled = False
        Me.btnHapus.Enabled = False
        Me.btnKeluar.Enabled = True
    End Sub

    Private Sub tbIdBarang_TextChanged(sender As Object, e As EventArgs) Handles tbIdBarang.TextChanged

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Call Kosong()
        Call TextHidup()
        Me.btnTambah.Enabled = False
        Me.btnSimpan.Enabled = True
        Me.btnEdit.Enabled = False
        Me.btnUpdate.Enabled = False
        Me.btnBatal.Enabled = False
        Me.btnHapus.Enabled = False
        Me.btnKeluar.Enabled = True
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If tbIdBarang.Text = "" Or tbNamaBarang.Text = "" = "" Then
            MsgBox("Data belum lengkap, pastikan semua form terisi")
            Exit Sub
        Else
            Call Koneksi()
            Dim simpan As String = "insert into tb_barang (kdbarang, nmbarang, satuan, jumlah, harga)" & "values ('" & tbIdBarang.Text & "','" & tbNamaBarang.Text & "','" & dtpTglProduksi.Text & "','" & tbIdProduksi.Text & "','" & tbIdSuplier.Text & "','" & tbIdKaryawan.Text & "','" & tbStokBarang.Text & "','" & tbHargaBarang.Text & "')"
            cmd = New OleDbCommand(simpan, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil di input", MsgBoxStyle.Information, "Information")
            Me.OleDbConnection1.Close()
            Call TampilGrid()
            dgvDataBarang.Refresh()
            Call Koneksi()
            Call Kosong()
            Call TextMati()
            Me.btnTambah.Enabled = True
            Me.btnSimpan.Enabled = False
            Me.btnEdit.Enabled = False
            Me.btnUpdate.Enabled = False
            Me.btnBatal.Enabled = False
            Me.btnHapus.Enabled = False
            Me.btnKeluar.Enabled = True
        End If
    End Sub
End Class
