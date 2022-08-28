using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımEviInsanKaynaklarıSistemi
{
    class Project
    {
        int ıd;
        public int Id
        {
            get { return ıd; }
            set { ıd = value; }
        }

        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        string sector;
        public string Sector
        {
            get { return sector; }
            set { sector = value; }
        }

        int minPer;
        public int MinPer
        {
            get { return minPer; }
            set { minPer = value; }
        }

        int maxPer;
        public int MaxPer
        {
            get { return maxPer; }
            set { maxPer = value; }
        }

        int mngrNo;
        public int MngrNo
        {
            get { return mngrNo; }
            set { mngrNo = value; }
        }

        int anlystNo;
        public int AnlystNo
        {
            get { return anlystNo; }
            set { anlystNo = value; }
        }

        int dsgnrNo;
        public int DsgnrNo
        {
            get { return dsgnrNo; }
            set { dsgnrNo = value; }
        }

        int dvlprNo;
        public int DvlprNo
        {
            get { return dvlprNo; }
            set { dvlprNo = value; }
        }

        int tstrNo;
        public int TstrNo
        {
            get { return tstrNo; }
            set { tstrNo = value; }
        }
    }
}
