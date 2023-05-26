<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InputProduksiBarang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        tbIdBarang = New TextBox()
        tbNamaBarang = New TextBox()
        dtpTglProduksi = New DateTimePicker()
        tbIdProduksi = New TextBox()
        tbIdSuplier = New TextBox()
        tbIdKaryawan = New TextBox()
        tbStokBarang = New TextBox()
        tbHargaBarang = New TextBox()
        btnTambah = New Button()
        btnSimpan = New Button()
        btnEdit = New Button()
        btnBatal = New Button()
        btnUpdate = New Button()
        btnHapus = New Button()
        btnKeluar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(279, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(447, 54)
        Label1.TabIndex = 0
        Label1.Text = "Input Produksi Barang"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(42, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 38)
        Label2.TabIndex = 1
        Label2.Text = "Id Barang"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(42, 166)
        Label3.Name = "Label3"
        Label3.Size = New Size(196, 38)
        Label3.TabIndex = 2
        Label3.Text = "Nama Barang"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(41, 241)
        Label4.Name = "Label4"
        Label4.Size = New Size(178, 38)
        Label4.TabIndex = 3
        Label4.Text = "Tgl Produksi"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(41, 318)
        Label5.Name = "Label5"
        Label5.Size = New Size(166, 38)
        Label5.TabIndex = 4
        Label5.Text = "Id Produksi"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(42, 396)
        Label6.Name = "Label6"
        Label6.Size = New Size(143, 38)
        Label6.TabIndex = 5
        Label6.Text = "Id Suplier"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(42, 476)
        Label7.Name = "Label7"
        Label7.Size = New Size(180, 38)
        Label7.TabIndex = 6
        Label7.Text = "Id Karyawan"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(41, 556)
        Label8.Name = "Label8"
        Label8.Size = New Size(177, 38)
        Label8.TabIndex = 7
        Label8.Text = "Stok Barang"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(41, 630)
        Label9.Name = "Label9"
        Label9.Size = New Size(197, 38)
        Label9.TabIndex = 8
        Label9.Text = "Harga Barang"
        ' 
        ' tbIdBarang
        ' 
        tbIdBarang.Location = New Point(330, 109)
        tbIdBarang.Name = "tbIdBarang"
        tbIdBarang.Size = New Size(280, 27)
        tbIdBarang.TabIndex = 9
        ' 
        ' tbNamaBarang
        ' 
        tbNamaBarang.Location = New Point(330, 177)
        tbNamaBarang.Name = "tbNamaBarang"
        tbNamaBarang.Size = New Size(280, 27)
        tbNamaBarang.TabIndex = 10
        ' 
        ' dtpTglProduksi
        ' 
        dtpTglProduksi.Location = New Point(330, 250)
        dtpTglProduksi.Name = "dtpTglProduksi"
        dtpTglProduksi.Size = New Size(280, 27)
        dtpTglProduksi.TabIndex = 11
        ' 
        ' tbIdProduksi
        ' 
        tbIdProduksi.Location = New Point(330, 329)
        tbIdProduksi.Name = "tbIdProduksi"
        tbIdProduksi.Size = New Size(280, 27)
        tbIdProduksi.TabIndex = 12
        ' 
        ' tbIdSuplier
        ' 
        tbIdSuplier.Location = New Point(330, 407)
        tbIdSuplier.Name = "tbIdSuplier"
        tbIdSuplier.Size = New Size(280, 27)
        tbIdSuplier.TabIndex = 13
        ' 
        ' tbIdKaryawan
        ' 
        tbIdKaryawan.Location = New Point(330, 487)
        tbIdKaryawan.Name = "tbIdKaryawan"
        tbIdKaryawan.Size = New Size(280, 27)
        tbIdKaryawan.TabIndex = 14
        ' 
        ' tbStokBarang
        ' 
        tbStokBarang.Location = New Point(330, 567)
        tbStokBarang.Name = "tbStokBarang"
        tbStokBarang.Size = New Size(280, 27)
        tbStokBarang.TabIndex = 15
        ' 
        ' tbHargaBarang
        ' 
        tbHargaBarang.Location = New Point(330, 643)
        tbHargaBarang.Name = "tbHargaBarang"
        tbHargaBarang.Size = New Size(280, 27)
        tbHargaBarang.TabIndex = 16
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(724, 109)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(137, 62)
        btnTambah.TabIndex = 17
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(724, 196)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(137, 62)
        btnSimpan.TabIndex = 18
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(724, 284)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(137, 62)
        btnEdit.TabIndex = 19
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(891, 109)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(137, 62)
        btnBatal.TabIndex = 20
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(891, 196)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(137, 62)
        btnUpdate.TabIndex = 21
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(891, 284)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(137, 62)
        btnHapus.TabIndex = 22
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(724, 372)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(304, 62)
        btnKeluar.TabIndex = 23
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' InputProduksiBarang
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(1066, 722)
        Controls.Add(btnKeluar)
        Controls.Add(btnHapus)
        Controls.Add(btnUpdate)
        Controls.Add(btnBatal)
        Controls.Add(btnEdit)
        Controls.Add(btnSimpan)
        Controls.Add(btnTambah)
        Controls.Add(tbHargaBarang)
        Controls.Add(tbStokBarang)
        Controls.Add(tbIdKaryawan)
        Controls.Add(tbIdSuplier)
        Controls.Add(tbIdProduksi)
        Controls.Add(dtpTglProduksi)
        Controls.Add(tbNamaBarang)
        Controls.Add(tbIdBarang)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "InputProduksiBarang"
        Text = "InputProduksiBarang"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents tbIdBarang As TextBox
    Friend WithEvents tbNamaBarang As TextBox
    Friend WithEvents dtpTglProduksi As DateTimePicker
    Friend WithEvents tbIdProduksi As TextBox
    Friend WithEvents tbIdSuplier As TextBox
    Friend WithEvents tbIdKaryawan As TextBox
    Friend WithEvents tbStokBarang As TextBox
    Friend WithEvents tbHargaBarang As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnKeluar As Button
End Class
