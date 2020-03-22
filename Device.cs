 class Device
    {

        //This what the device class knows
        public string Name { get; set; }

        private string IpAddress;
        public string ipaddress { get { return IpAddress; } set { IpAddress = value; } }
        public string Location;
        public bool status;
        
       // Label theLabel;

        //This loads a 2D array of all the locations and associated IP's of the WS
        //This is taken from EMC

        //Lets build our constructor here
        //Passes the Name, Location and status of on or off, default is off

            /// <summary>
            /// Constructor, takes in two string parameters then convers the stat into a bool
            /// </summary>
            /// <param name="name"></param>
            /// <param name="stat"></param>
            /// <param name="dLabel"></param>
        public Device(string name, string stat)
        {
            Name = name;
            //Get the IP of the device as it is initialized
            IpAddress = GetIP();

            //Pass me the status of the WS, is it in the office or out in the field?
            if (stat == "true")
            {
                status = true;
            }
            else
            {
                status = false;
            }

            //Also test to see that the ping is successful and not faulty by 
            //seeing if you can reach it out with a UNC path

            //If the status is active then look for it and cross reference it with
            //the 2d array to find if its in emc
        }


        //This is what the Device Class can do 

        //GEt a ping reponce of wether the device is up and running
        public bool GetPing()
        {
            bool pingable = false;
            Ping pinger = new Ping();

            try
            {
                PingReply reply = pinger.Send(IpAddress);
                pingable = reply.Status == IPStatus.Success;



            }
            catch (PingException)
            {
                // Discard PingExceptions and return false;
            }

            return pingable;
            //Return True if I am able to ping device

        }

        //Baased on the IP, the get location method
        //returns the name(location) associated in EMC

        //GR 6-13 needs work, default it returns false

        public virtual string GetLocation()
        {
            //Gets Location of WS
            //After much struggle i found it to be better if I flipped the @D array to have [ip,location]
            //Since this code will return better 
            string a = "";
            return a;
        }

        //From DNS this function/ method gets the IP associated with the WS

        /// <summary>
        /// Get the ip of the Device
        /// </summary>
        /// <returns></returns>
        public string GetIP()
        {
            //Get Ip of WS
            try
            {
                var address = System.Net.Dns.GetHostAddresses(Name)[0];


                return address.ToString();
            }

            catch (Exception e)
            {
                return " [Ip not found] ";
            }
        }



        /// <summary>
        /// Update the Label associated with the device, by ping
        /// </summary>
       /* public void UpdateLabel()
        {

            if (GetPing())
            {
                theLabel.Text = "Good Ping";
                theLabel.ForeColor = System.Drawing.Color.Green;

            }

            else if (!status)
            {
                theLabel.Text = "Not in Net";
                theLabel.ForeColor = System.Drawing.Color.Blue;
            }
            else
            {
                theLabel.Text = "Bad   Ping";

                theLabel.ForeColor = System.Drawing.Color.Red;
            }

        }
        */



      



       
    }
