sebuah proyek game First Person Shooter (FPS) berbasis Unity yang menggunakan sistem input modern (Input System) dan dirancang untuk berjalan pada berbagai platform, termasuk PC dan mobile. Proyek ini mencakup sistem kontrol pemain, tampilan pemain (look), serta scene dan prefab dasar untuk gameplay FPS.

🧩 Fitur Utama
🎮 Player Controller dengan input sistem baru (PlayerInput.inputactions)

👁️ Player Look untuk kontrol kamera/mouse secara bebas

🕹️ Input Manager untuk menangani input pengguna secara modular

🏗️ Prefab Pemain siap digunakan dan dimodifikasi

🌍 Sample Scene sebagai area pengujian dan pengembangan awal

📦 Render Pipeline menggunakan URP (Universal Render Pipeline) untuk performa optimal di PC dan mobile

⚙️ Pengaturan Proyek Lengkap di ProjectSettings/ dan Settings/ untuk mendukung fitur grafis dan input

📁 Struktur Direktori
Assets/Input — Script dan file konfigurasi Input System

Assets/PreFabs — Prefab karakter atau objek yang bisa digunakan kembali

Assets/Scenes — Sample scene Unity

Assets/Scripts — Kode utama seperti gerakan, input, dan logika pemain

Assets/Settings — Profil render dan pengaturan URP untuk platform berbeda

Assets/TutorialInfo — File bantu dan dokumentasi dari template/tutorial

Packages/ — File dependency Unity (manifest dan lock)

ProjectSettings/ — Konfigurasi keseluruhan proyek seperti render, quality, physics, dll.

🚀 Cara Menjalankan
Buka Unity Hub.

Pilih "Add", arahkan ke folder stevanza-fps-unity/.

Buka proyek dan pastikan URP terinstall dari Package Manager.

Jalankan SampleScene dari folder Assets/Scenes/.

✅ Ketergantungan
Unity Editor (versi minimal 2021.3 LTS disarankan)

Unity Input System

Universal Render Pipeline (URP)
