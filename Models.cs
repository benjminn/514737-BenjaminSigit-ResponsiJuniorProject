using System;

namespace Responsi2
{
    public abstract class BaseEntity
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }

    public class Proyek : BaseEntity
    {
        private string namaProyek = string.Empty;
        private string client = string.Empty;
        private decimal budget;

        public string NamaProyek
        {
            get { return namaProyek; }
            set { namaProyek = value; }
        }

        public string Client
        {
            get { return client; }
            set { client = value; }
        }

        public decimal Budget
        {
            get { return budget; }
            set { budget = value; }
        }

        public Proyek()
        {
        }

        public Proyek(int id, string namaProyek, string client, decimal budget)
        {
            this.Id = id;
            this.namaProyek = namaProyek;
            this.client = client;
            this.budget = budget;
        }

        public override string ToString()
        {
            return namaProyek;
        }
    }

    public abstract class Developer : BaseEntity
    {
        private string namaDeveloper = string.Empty;
        private int idProyek;
        private string statusKontrak = string.Empty;
        private int fiturSelesai;
        private int jumlahBug;

        public string NamaDeveloper
        {
            get { return namaDeveloper; }
            set { namaDeveloper = value; }
        }

        public int IdProyek
        {
            get { return idProyek; }
            set { idProyek = value; }
        }

        public string StatusKontrak
        {
            get { return statusKontrak; }
            set { statusKontrak = value; }
        }

        public int FiturSelesai
        {
            get { return fiturSelesai; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Fitur selesai tidak boleh negatif");
                fiturSelesai = value;
            }
        }

        public int JumlahBug
        {
            get { return jumlahBug; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Jumlah bug tidak boleh negatif");
                jumlahBug = value;
            }
        }

        public abstract int HitungSkor();
        public abstract decimal HitungTotalGaji();

        public Developer()
        {
        }

        public Developer(int id, string namaDeveloper, int idProyek, string statusKontrak, int fiturSelesai, int jumlahBug)
        {
            this.Id = id;
            this.namaDeveloper = namaDeveloper;
            this.idProyek = idProyek;
            this.statusKontrak = statusKontrak;
            this.FiturSelesai = fiturSelesai;
            this.JumlahBug = jumlahBug;
        }
    }

    public class DeveloperFulltime : Developer
    {
        public DeveloperFulltime() : base() { }

        public DeveloperFulltime(int id, string namaDeveloper, int idProyek, int fiturSelesai, int jumlahBug)
            : base(id, namaDeveloper, idProyek, "Fulltime", fiturSelesai, jumlahBug)
        {
        }

        public override int HitungSkor()
        {
            int skor = (10 * FiturSelesai) - (5 * JumlahBug);
            return skor < 0 ? 0 : skor;
        }

        public override decimal HitungTotalGaji()
        {
            return 5000000 + (HitungSkor() * 20000);
        }
    }

    public class DeveloperFreelance : Developer
    {
        public DeveloperFreelance() : base() { }

        public DeveloperFreelance(int id, string namaDeveloper, int idProyek, int fiturSelesai, int jumlahBug)
            : base(id, namaDeveloper, idProyek, "Freelance", fiturSelesai, jumlahBug)
        {
        }

        public override int HitungSkor()
        {
            if (FiturSelesai == 0)
                return 0;

            double skorHitung = 100 * (1 - ((2.0 * JumlahBug) / (3.0 * FiturSelesai)));
            int skor = (int)Math.Round(skorHitung);
            return skor < 0 ? 0 : skor;
        }

        public override decimal HitungTotalGaji()
        {
            int skor = HitungSkor();

            if (skor >= 80)
                return 500000m * FiturSelesai;
            else if (skor >= 50)
                return 400000m * FiturSelesai;
            else
                return 250000m * FiturSelesai;
        }
    }
}
