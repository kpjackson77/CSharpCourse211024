using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherNamespace
{
  internal class Class1
  {
        public string Message { get; set; }

		private int _val;
		public int Val
		{
			get { return _val; }
			set { _val = value; }
		}

  }
}
