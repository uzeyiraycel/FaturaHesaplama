# FaturaHesaplama
## C# winforms da belirli kriterlere göre faturada indirim yapan program
### Program Nasıl Çalışır ?

Program 2 farklı indirim türü baz alınarak yapılmıştır. <br/> 1. yüzde bazlı indirimler ve 2. ise her $200 için yapılan $5 indirimdir (sabit indirim). <br/>
Müşteri kendine uyan yüzde bazlı indirimlerden sadece bir tanesinden (en yüksek yüzdelik indirim oranı) yararlanmaktadır ve bunun yanı sıra sabit indirim almaktadır. <br/>
Eğer alınan ürün telefon ise yüzde bazlı indirim şartlarını sağlasa bile yararlanamamaktadır ancak sabit indirimden yararlanabilmektedir. <br/>
##### Örnek Senaryo
Kullanıcı gümüş kart sahibi, mağaza üyeliği var ve aynı zamanda 2 yıldan fazla süredir müşteri (Telefon almamıştır). <br/> Fatura Tutarı: $200 <br/> Yüzdelik indirimlerden en fazla gümüş kart
üyeliği olduğu için %20 indirim alır buna ek olarak $200 için $5 indirim alacaktır.<br/>
Ödenecek Tutar: $155 <br/>
Üstte senaryo aynen geçerli fakat alınan ürün telefon olsaydı yüzde bazlı indirimlerden yararlanamayacak sadece sabit indirimden yararlanabilecektir. <br/>
Ödenecek Tutar: $195
