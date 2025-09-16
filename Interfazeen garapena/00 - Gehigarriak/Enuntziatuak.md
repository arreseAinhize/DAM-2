**Ariketa 1:** *Sortu zenbakien aplikazioa.*

&nbsp;- Hasieran “Numero1” botoia bakarrik aktibatuta dago.

&nbsp;- Testu kutxan lehenengo zenbakia idatzi eta Numero1 botoia sakatzen dugu → hau desaktibatuta geratzen da eta Numero2 aktibatuta.

&nbsp;- Gauza bera gertatzen da Numero2–Numero5 botoiekin.

&nbsp;- Bosgarren botoia sakatu ondoren “Kalkulatu” eta “Garbitu” botoiak aktibatzen dira.

&nbsp;- Kalkulatu botoia sakatzean, 5 zenbakien batuketa erakusten da MessageBox batean.

&nbsp;- Garbitu botoia sakatzean, aplikazioa hasierako egoerara bueltatzen da eta fokoa testu kutxan jartzen da.



👉 **Klase bat egin, Zenbakia izenekoa:**

&nbsp;- Propietate bat soilik irakurtzeko: Suma.

&nbsp;- Metodo bat: AddNumero(int n) → sarrerako zenbakia gehitzen du barneko akumulagailura.







**Ariketa 2:** *Sortu hitzak biltzeko aplikazioa.*

&nbsp;- Hasieran “Hitza1” botoia bakarrik aktibatuta dago.

&nbsp;- Testu kutxan lehenengo hitza idatzi eta Hitza1 botoia sakatzean → hau desaktibatuta geratzen da eta Hitza2 aktibatuta.

&nbsp;- Horrela jarraitzen da Hitza3 arte.

&nbsp;- Hirugarren botoia sakatu ondoren, “Invertitu” eta “Garbitu” botoiak aktibatzen dira.

&nbsp;- Invertitu botoia sakatzean, 3 hitzak ordenaren alderantziz erakusten dira MessageBox batean, tarte zuri batekin bereizita.

&nbsp;- Garbitu botoia sakatzean, aplikazioa berriro hasierako egoerara bueltatzen da.



👉 **Klase bat egin, Hitza izenekoa:**

&nbsp;- Barnean lista pribatu bat edukiko du hitzak gordetzeko.

&nbsp;- Propietate bat soilik irakurtzeko: Inverso (hitz guztiak alderantziz concatenatuta).

&nbsp;- Metodo bat: AddHitza(string testua) → hitza listan gehitzen du.



**Ariketa 3**: *Sortu ikasleen notak kudeatzeko aplikazioa.*

&nbsp;- Hasieran “Nota1” botoia bakarrik aktibatuta dago.

&nbsp;- Testu kutxan lehenengo nota (0–10 bitartean) idatzi eta Nota1 botoia sakatzean → hau desaktibatuta geratzen da eta Nota2 aktibatuta.

&nbsp;- Horrela jarraitzen da Nota4 arte.

&nbsp;- Laugarren botoia sakatu ondoren, “Media” eta “Reset” botoiak aktibatzen dira.

&nbsp;- Media botoia sakatzean, 4 noten batezbestekoa erakusten da MessageBox batean (adib. “Batezbestekoa: 7.25”).

&nbsp;- Reset botoia sakatzean, aplikazioa berriro hasierako egoerara bueltatzen da eta fokoa testu kutxan jartzen da.



👉 **Klase bat egin, Nota izenekoa:**

&nbsp;- Barnean lista pribatu bat edukiko du notak gordetzeko.

&nbsp;- Propietate bat soilik irakurtzeko: Media (double gisa).

&nbsp;- Metodo bat: AddNota(double n) → nota listan gehitzen du.

**Ariketa 4**: *Sortu hirien aplikazioa.*

&nbsp;- Hasieran “Hiria1” botoia bakarrik aktibatuta dago.

&nbsp;- Testu kutxan lehenengo hiriaren izena idatzi eta Hiria1 botoia sakatzean → hau desaktibatuta geratzen da eta Hiria2 aktibatuta.

&nbsp;- Horrela jarraitzen da Hiria3–Hiria5 arte.

&nbsp;- Bostgarren botoia sakatu ondoren, “Lotu” eta “Garbitu” botoiak aktibatzen dira.

&nbsp;- Lotu botoia sakatzean, 5 hiriak erakusten dira MessageBox batean, bakoitza lerro berrian.
```Adibidea:
Bilbao  
Donostia  
Gasteiz  
Iruña  
Baiona
```  

&nbsp;- Garbitu botoia sakatzean, aplikazioa berriro hasierako egoerara bueltatzen da eta fokoa testu kutxan jartzen da.

**👉 Klasea: Hiria**

&nbsp;- Barnean lista pribatu bat edukiko du hirien izenak gordetzeko.

&nbsp;- Propietate bat soilik irakurtzeko: Guztiak (hiri guztiak string batean itzultzen ditu, \n bidez bereizita).

&nbsp;- Metodo bat: AddHiria(string izena) → hiria listan gehitzen du.