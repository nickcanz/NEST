﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawClientGenerator
{
	class Program
	{
		static void Main(string[] args)
		{
			var useCache = (args.Length > 0 && args[0] == "cache");

			var spec = ApiGenerator.GetRestSpec(useCache: useCache);

			ApiGenerator.GenerateClientInterface(spec);

			ApiGenerator.GenerateQueryStringParameters(spec);

			ApiGenerator.GenerateEnums(spec);

			ApiGenerator.GenerateRawClient(spec);

			Console.WriteLine("Found {0} api documentation endpoints", spec.Endpoints.Count());
		}
	}
}
