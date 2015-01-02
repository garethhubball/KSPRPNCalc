﻿// This file is part of KerbalRPNCalc.
// 
// KerbalRPNCalc is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// KerbalRPNCalc is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with KerbalRPNCalc. If not, see <http://www.gnu.org/licenses/>.

namespace KerbalRPNCalc
{
    internal class Engine
    {
        public string Name { get; private set; }
        public float ISP { get; private set; }

        public Engine(string name, float isp)
        {
            Name = name;
            ISP = isp;
        }
    }
}