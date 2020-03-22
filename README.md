# C-Projects ((Beta) Network Monitor)
These are projects I myself coded, with the help of resources of course. 

TL;DR
(Beta Network Monitor)
Using internal tools such as the WMI namespace as well as some commands to the command line, this program uses OOP principles to 
create a list of network devices, which will tell me with a ping if they are reachable. Each device class allows me to RDP, Ping, 
connect to UNC path, restart, and Shutdown. Code writen by me, with extensive research and some code from online (such  as reading
in an interlop framework with Excel sheet).

(Network Monitor 1.0)
More objects were added using inheritance off the Device Class. Approach was more modular style of programming for easier to read and
update. Changes that can be made. Add devices to DB instead of having hardcoded excel sheet to keep update. Unfourtunately, no longer in 
Hyatt Domain Net Env so this can be re-purposed to monitor other devices given a list of IP addresses. 
*If SNMP allowed, canm create code to 'sniff' out network attached devices to network. This means no need to have list of Devices and IP addresses.
