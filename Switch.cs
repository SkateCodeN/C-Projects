class Switch : Device
    {
        public Switch(string name, bool stat, string ip, string location, Label aLabel) : base(name, stat, aLabel)
        {
            Name = name;
            status = stat;
            ipaddress = ip;
            Location = location;
        }
    }
