1 - MVC Projesi oluşturulur. 
2 - Yapılan DB mimarisine göre claslar ve clasların içerisinde tablo ilişkileri kurulur. 
    örn: ICollection
3 - Context.cs oluşturulur, EntityFremawork Yüklenir. 
4 - Context.cs içerisinde oluşturulacak DB tabloları ve alanları BD set ile birlikte oluşturulan class seçilir.
5 - Context.cs içerisinde oluşturulan DB alan ve ilişkilerin DB de oluşması için aşağıdaki adımlar izlenir. 
        * View > Other Windows > Package manager console açılır. 
        * enable-migrations yazılır. 
        * Yükleme işlemi tamamlandıktan sonra solition da Migrations > Configuration.cs dosyası olusur. 
        * AutomaticMigrationsEnabled = true; yapılır.

6 - Package manager console > update-database yazılır. Bu koddan sonra DB otomatik olarak oluşacaktır.
7 - update-database -Force komutu DB de değişiklik olduğu zaman kullanılır.
8 - https://startbootstrap.com/template/sb-admin adresine gidilerek template indirilir. 
9 - Web klasorü içerisine atılarak düzenlemeler yapılır. 
10 - WEb klasoru içerisinde index.html AdminLayout.cshtml içerisine tasınarak css yolları düzenlenir.
11 - Main tagı kaldırılır.  @RenderBody() atılır.
12 - https://astronautweb.co/snippet/font-awesome/ adresine gidilerek istenilen icon seçilir. (fa-list-alt)
  <a class="nav-link" href="index.html">
                            <div class="sb-nav-link-icon"><i class="fas fa-list-alt"></i></div>
                          Ürünler
                        </a>

13 - using MVC5_Otomasyon.Models.Classes; listelenmek istenen controller eklenir. context - db erişim için