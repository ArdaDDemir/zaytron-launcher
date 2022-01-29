# Minecraft Launcher

<img src="http://ardademir.me/cdn/ML.jpg" align="right"
     alt="Logo" width="120" height="120">

Minecraft launcher herhangi bir sürüm seçip anında minecrafta girebileceğiniz ücretsiz ve açık kaynaklı bir launcherdır

* Minecraftın **tüm** sürümleri destekleniyor.
* **Onlinemode = false** olan tüm sunuculara rahatlıkla girebilirsiniz.
* Discord Rich Presence entegre edilmiştir.

# Örnek Görseller
**Yükleniyor Sayfası**
<p align="left">
  <img src="https://cdn.ardademir.me/img/Screenshot_1.png" alt="Görsel 2" width="512" height="712">
</p>

**Discord Rich Presence**
<p align="left">
  <img src="https://cdn.ardademir.me/img/Screenshot_4.png" alt="Görsel 2" width="512" height="712">
</p>

**Açılış Sayfası**

<p align="left">
  <img src="https://cdn.ardademir.me/img/Screenshot_3.png" alt="Görsel 2" width="512" height="712">
</p>

**Discord Rich Presence**
<p align="left">
  <img src="https://cdn.ardademir.me/img/Screenshot_5.png" alt="Görsel 2" width="512" height="712">
</p>

# Nasıl Özelleştirilir?

**Discord Rich Presence Özelleştirme**

1. Öncelikle https://discord.com/developers/applications sayfasını açın
2. New Application a tıklayın isim girip create ye tıklayın
3. Application idnizi kopyalayın ve **Application id** yerine yapıştırın
4. Rich presence kısmına gelin add image e basın ve resim yükleyin (resim ismini unutmayın)
5. Yüklediğiniz resimleri isimlerini **kresim** **bresim** kısmına yapıştırın (kresim küçük resimdir bresim büyük olandır)
6. Resimlere gelince ne yazmasını istiyorsanız **krdetay** **brdetay** kısmına yazın (krdetay küçük resimdir brdetay büyük olandır)
7. Ne yazmasını istediğinizi **Detay** ve **Detay2** kısmına yazın

**Uyarı**
Resimler 5- 20 dakika içinde discorda yüklenir bundan dolayı hata verebilir

**Örnek**

```
this.handlers = default(discordRPC.EventHandlers);
discordRPC.Initialize("Application id", ref this.handlers, true, null);
this.presence.details = "Detay";
this.presence.state = "Detay2";
this.presence.largeImageKey = "kresim";
this.presence.smallImageKey = "bresim";
this.presence.largeImageText = "krdetay";
this.presence.smallImageText = "brdetay";
this.presence.startTimestamp = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
discordRPC.UpdatePresence(ref this.presence);
path();
```

