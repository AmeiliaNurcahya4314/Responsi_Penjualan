﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    public class Penjualan
    {
        public string nota { get; set; }
        public string tanggal { get; set; }
        public string nama { get; set; }
        public string jenis { get; set; }
        public int total { get; set; }

        public Penjualan(string nota, string tanggal,string nama, string jenis,int total)
        {
            this.nota = nota;
            this.nama = nama;
            this.tanggal = tanggal;
            this.jenis = jenis;
            this.total = total;
            Console.WriteLine("Yeayyy Data berhasil ditambahkan !\n");
        }
    }
}
