﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class penerbangan
{
    public penerbangan()
    {
        this.tiket = new HashSet<tiket>();
    }

    public int id { get; set; }
    public string nama_maskapai { get; set; }
    public string kota_asal { get; set; }
    public string kota_tujuan { get; set; }
    public string bandara_asal { get; set; }
    public string bandara_tujuan { get; set; }
    public string kota_transit { get; set; }
    public string bandara_transit { get; set; }
    public System.DateTime tanggal_keberangkatan { get; set; }
    public string jam_keberangkatan { get; set; }
    public string jam_tiba { get; set; }
    public string durasi { get; set; }
    public int bagasi_maksimum { get; set; }
    public int harga { get; set; }

    public virtual ICollection<tiket> tiket { get; set; }
}

public partial class penumpang
{
    public int id { get; set; }
    public int id_tiket { get; set; }
    public string nama { get; set; }
    public string nomor_identitas { get; set; }

    public virtual tiket tiket { get; set; }
}

public partial class sysdiagrams
{
    public string name { get; set; }
    public int principal_id { get; set; }
    public int diagram_id { get; set; }
    public Nullable<int> version { get; set; }
    public byte[] definition { get; set; }
}

public partial class tiket
{
    public tiket()
    {
        this.penumpang = new HashSet<penumpang>();
    }

    public int id { get; set; }
    public int id_penerbangan { get; set; }
    public string kode_booking { get; set; }
    public Nullable<System.DateTime> waktu_booking { get; set; }
    public Nullable<System.DateTime> batas_waktu_bayar_atm { get; set; }
    public Nullable<System.DateTime> batas_waktu_bayar_internet_banking { get; set; }
    public string kode_bayar { get; set; }
    public string status { get; set; }
    public Nullable<int> user_id { get; set; }
    public Nullable<long> total_harga { get; set; }

    public virtual penerbangan penerbangan { get; set; }
    public virtual ICollection<penumpang> penumpang { get; set; }
}