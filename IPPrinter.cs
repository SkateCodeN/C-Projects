class IPprinter : Device
    {
        public IPprinter(string name, bool stat, string ip, Label aLabel, string loc) : base(name, stat, aLabel)
        {
            Name = name;
            status = stat;
            ipaddress = ip;
            Location = loc;
        }
    }
