using Newtonsoft.Json;

namespace api.Models
{
#nullable disable
    public class Af
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class Am
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Ar
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Script> scripts { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class As
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Script> scripts { get; set; }
    }

    public class Az
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Ba
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Be
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public List<Script> scripts { get; set; }
    }

    public class Bg
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Script> scripts { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class Bn
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Script> scripts { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class Bo
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Brx
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public List<Script> scripts { get; set; }
    }

    public class Bs
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class Ca
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class Cs
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class Cy
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class Da
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class De
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class Dictionary
    {
        public Af af { get; set; }
        public Ar ar { get; set; }
        public Bg bg { get; set; }
        public Bn bn { get; set; }
        public Bs bs { get; set; }
        public Ca ca { get; set; }
        public Cs cs { get; set; }
        public Cy cy { get; set; }
        public Da da { get; set; }
        public De de { get; set; }
        public El el { get; set; }
        public En en { get; set; }
        public Es es { get; set; }
        public Et et { get; set; }
        public Fa fa { get; set; }
        public Fi fi { get; set; }
        public Fr fr { get; set; }
        public He he { get; set; }
        public Hi hi { get; set; }
        public Hr hr { get; set; }
        public Hu hu { get; set; }
        public Id id { get; set; }
        public Is @is { get; set; }
        public It it { get; set; }
        public Ja ja { get; set; }
        public Ko ko { get; set; }
        public Lt lt { get; set; }
        public Lv lv { get; set; }
        public Ms ms { get; set; }
        public Mt mt { get; set; }
        public Mww mww { get; set; }
        public Nb nb { get; set; }
        public Nl nl { get; set; }
        public Pl pl { get; set; }
        public Pt pt { get; set; }
        public Ro ro { get; set; }
        public Ru ru { get; set; }
        public Sk sk { get; set; }
        public Sl sl { get; set; }

        [JsonProperty("sr-Latn")]
        public SrLatn srLatn { get; set; }
        public Sv sv { get; set; }
        public Sw sw { get; set; }
        public Ta ta { get; set; }
        public Th th { get; set; }

        [JsonProperty("tlh-Latn")]
        public TlhLatn tlhLatn { get; set; }
        public Tr tr { get; set; }
        public Uk uk { get; set; }
        public Ur ur { get; set; }
        public Vi vi { get; set; }

        [JsonProperty("zh-Hans")]
        public ZhHans zhHans { get; set; }
    }

    public class Dsb
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Dv
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class El
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Script> scripts { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class En
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class Es
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class Et
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class Eu
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Fa
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Script> scripts { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class Fi
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class Fil
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Fj
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Fo
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Fr
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class FrCA
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Ga
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Gl
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Gom
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Script> scripts { get; set; }
    }

    public class Gu
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Script> scripts { get; set; }
    }

    public class Ha
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class He
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Script> scripts { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class Hi
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Script> scripts { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class Hr
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class Hsb
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Ht
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Hu
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class Hy
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Id
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class Ig
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Ikt
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Is
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class It
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class Iu
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class IuLatn
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Ja
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Script> scripts { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class Ka
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Kk
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Script> scripts { get; set; }
    }

    public class Km
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Kmr
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Kn
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Script> scripts { get; set; }
    }

    public class Ko
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Script> scripts { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class Ks
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public List<Script> scripts { get; set; }
    }

    public class Ku
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Ky
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Script> scripts { get; set; }
    }

    public class Ln
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Lo
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Lt
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class Lug
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Lv
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class Lzh
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Mai
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Script> scripts { get; set; }
    }

    public class Mg
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Mi
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Mk
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Script> scripts { get; set; }
    }

    public class Ml
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Script> scripts { get; set; }
    }

    public class MnCyrl
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Script> scripts { get; set; }
    }

    public class Mni
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public List<Script> scripts { get; set; }
    }

    public class MnMong
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Mr
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Script> scripts { get; set; }
    }

    public class Ms
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class Mt
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class Mww
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class My
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Nb
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class Ne
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Script> scripts { get; set; }
    }

    public class Nl
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class Nso
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Nya
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Or
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Script> scripts { get; set; }
    }

    public class Otq
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Pa
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Script> scripts { get; set; }
    }

    public class Pl
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class Prs
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Ps
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Pt
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class PtPT
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Ro
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class Language
    {
        public Translation3 translation { get; set; }
        public Transliteration transliteration { get; set; }
        public Dictionary dictionary { get; set; }
    }

    public class Ru
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Script> scripts { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class Run
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Rw
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Sa
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public List<Script> scripts { get; set; }
    }

    public class Script
    {
        public string code { get; set; }
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<ToScript> toScripts { get; set; }
    }

    public class Sd
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Script> scripts { get; set; }
    }

    public class Si
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Script> scripts { get; set; }
    }

    public class Sk
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class Sl
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class Sm
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Sn
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class So
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Sq
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class SrCyrl
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Script> scripts { get; set; }
    }

    public class SrLatn
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Script> scripts { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class St
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Sv
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class Sw
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class Ta
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Script> scripts { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class Te
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Script> scripts { get; set; }
    }

    public class Tg
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public List<Script> scripts { get; set; }
    }

    public class Th
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Script> scripts { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class Ti
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Tk
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class TlhLatn
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class TlhPiqd
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Tn
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class To
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class ToScript
    {
        public string code { get; set; }
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Tr
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class Translation3
    {
        public Af af { get; set; }
        public Am am { get; set; }
        public Ar ar { get; set; }
        public As @as { get; set; }
        public Az az { get; set; }
        public Ba ba { get; set; }
        public Bg bg { get; set; }
        public Bn bn { get; set; }
        public Bo bo { get; set; }
        public Bs bs { get; set; }
        public Ca ca { get; set; }
        public Cs cs { get; set; }
        public Cy cy { get; set; }
        public Da da { get; set; }
        public De de { get; set; }
        public Dsb dsb { get; set; }
        public Dv dv { get; set; }
        public El el { get; set; }
        public En en { get; set; }
        public Es es { get; set; }
        public Et et { get; set; }
        public Eu eu { get; set; }
        public Fa fa { get; set; }
        public Fi fi { get; set; }
        public Fil fil { get; set; }
        public Fj fj { get; set; }
        public Fo fo { get; set; }
        public Fr fr { get; set; }

        [JsonProperty("fr-CA")]
        public FrCA frCA { get; set; }
        public Ga ga { get; set; }
        public Gl gl { get; set; }
        public Gom gom { get; set; }
        public Gu gu { get; set; }
        public Ha ha { get; set; }
        public He he { get; set; }
        public Hi hi { get; set; }
        public Hr hr { get; set; }
        public Hsb hsb { get; set; }
        public Ht ht { get; set; }
        public Hu hu { get; set; }
        public Hy hy { get; set; }
        public Id id { get; set; }
        public Ig ig { get; set; }
        public Ikt ikt { get; set; }
        public Is @is { get; set; }
        public It it { get; set; }
        public Iu iu { get; set; }

        [JsonProperty("iu-Latn")]
        public IuLatn iuLatn { get; set; }
        public Ja ja { get; set; }
        public Ka ka { get; set; }
        public Kk kk { get; set; }
        public Km km { get; set; }
        public Kmr kmr { get; set; }
        public Kn kn { get; set; }
        public Ko ko { get; set; }
        public Ku ku { get; set; }
        public Ky ky { get; set; }
        public Ln ln { get; set; }
        public Lo lo { get; set; }
        public Lt lt { get; set; }
        public Lug lug { get; set; }
        public Lv lv { get; set; }
        public Lzh lzh { get; set; }
        public Mai mai { get; set; }
        public Mg mg { get; set; }
        public Mi mi { get; set; }
        public Mk mk { get; set; }
        public Ml ml { get; set; }

        [JsonProperty("mn-Cyrl")]
        public MnCyrl mnCyrl { get; set; }

        [JsonProperty("mn-Mong")]
        public MnMong mnMong { get; set; }
        public Mr mr { get; set; }
        public Ms ms { get; set; }
        public Mt mt { get; set; }
        public Mww mww { get; set; }
        public My my { get; set; }
        public Nb nb { get; set; }
        public Ne ne { get; set; }
        public Nl nl { get; set; }
        public Nso nso { get; set; }
        public Nya nya { get; set; }
        public Or or { get; set; }
        public Otq otq { get; set; }
        public Pa pa { get; set; }
        public Pl pl { get; set; }
        public Prs prs { get; set; }
        public Ps ps { get; set; }
        public Pt pt { get; set; }

        [JsonProperty("pt-PT")]
        public PtPT ptPT { get; set; }
        public Ro ro { get; set; }
        public Ru ru { get; set; }
        public Run run { get; set; }
        public Rw rw { get; set; }
        public Sd sd { get; set; }
        public Si si { get; set; }
        public Sk sk { get; set; }
        public Sl sl { get; set; }
        public Sm sm { get; set; }
        public Sn sn { get; set; }
        public So so { get; set; }
        public Sq sq { get; set; }

        [JsonProperty("sr-Cyrl")]
        public SrCyrl srCyrl { get; set; }

        [JsonProperty("sr-Latn")]
        public SrLatn srLatn { get; set; }
        public St st { get; set; }
        public Sv sv { get; set; }
        public Sw sw { get; set; }
        public Ta ta { get; set; }
        public Te te { get; set; }
        public Th th { get; set; }
        public Ti ti { get; set; }
        public Tk tk { get; set; }

        [JsonProperty("tlh-Latn")]
        public TlhLatn tlhLatn { get; set; }

        [JsonProperty("tlh-Piqd")]
        public TlhPiqd tlhPiqd { get; set; }
        public Tn tn { get; set; }
        public To to { get; set; }
        public Tr tr { get; set; }
        public Tt tt { get; set; }
        public Ty ty { get; set; }
        public Ug ug { get; set; }
        public Uk uk { get; set; }
        public Ur ur { get; set; }
        public Uz uz { get; set; }
        public Vi vi { get; set; }
        public Xh xh { get; set; }
        public Yo yo { get; set; }
        public Yua yua { get; set; }
        public Yue yue { get; set; }

        [JsonProperty("zh-Hans")]
        public ZhHans zhHans { get; set; }

        [JsonProperty("zh-Hant")]
        public ZhHant zhHant { get; set; }
        public Zu zu { get; set; }
    }

    public class Translation10
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public string code { get; set; }
    }

    public class Transliteration
    {
        public Ar ar { get; set; }
        public As @as { get; set; }
        public Be be { get; set; }
        public Bg bg { get; set; }
        public Bn bn { get; set; }
        public Brx brx { get; set; }
        public El el { get; set; }
        public Fa fa { get; set; }
        public Gom gom { get; set; }
        public Gu gu { get; set; }
        public He he { get; set; }
        public Hi hi { get; set; }
        public Ja ja { get; set; }
        public Kk kk { get; set; }
        public Kn kn { get; set; }
        public Ko ko { get; set; }
        public Ks ks { get; set; }
        public Ky ky { get; set; }
        public Mai mai { get; set; }
        public Mk mk { get; set; }
        public Ml ml { get; set; }

        [JsonProperty("mn-Cyrl")]
        public MnCyrl mnCyrl { get; set; }
        public Mni mni { get; set; }
        public Mr mr { get; set; }
        public Ne ne { get; set; }
        public Or or { get; set; }
        public Pa pa { get; set; }
        public Ru ru { get; set; }
        public Sa sa { get; set; }
        public Sd sd { get; set; }
        public Si si { get; set; }

        [JsonProperty("sr-Cyrl")]
        public SrCyrl srCyrl { get; set; }

        [JsonProperty("sr-Latn")]
        public SrLatn srLatn { get; set; }
        public Ta ta { get; set; }
        public Te te { get; set; }
        public Tg tg { get; set; }
        public Th th { get; set; }
        public Tt tt { get; set; }
        public Uk uk { get; set; }
        public Ur ur { get; set; }

        [JsonProperty("zh-Hans")]
        public ZhHans zhHans { get; set; }

        [JsonProperty("zh-Hant")]
        public ZhHant zhHant { get; set; }
    }

    public class Tt
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Script> scripts { get; set; }
    }

    public class Ty
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Ug
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Uk
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Script> scripts { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class Ur
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Script> scripts { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class Uz
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Vi
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class Xh
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Yo
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Yua
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class Yue
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }

    public class ZhHans
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Script> scripts { get; set; }
        public List<Translation3> translations { get; set; }
    }

    public class ZhHant
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
        public List<Script> scripts { get; set; }
    }

    public class Zu
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string dir { get; set; }
    }


}