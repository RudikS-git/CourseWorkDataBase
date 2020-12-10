using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseWorkDataBase.Models.Accessory;
using Microsoft.EntityFrameworkCore;

namespace CourseWorkDataBase.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Belong> Belongs { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<FeatureGroup> FeatureGroups { get; set; }
        public DbSet<Keep> Keeps { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Storage> Storages { get; set; }

        public DbSet<Accessory.Accessory> Accessories { get; set; }

        public DbSet<CaptureBoard> CaptureBoards { get; set; }
        public DbSet<Case> Cases { get; set; }
        public DbSet<CPU> CPUs { get; set; }
        public DbSet<GraphicsCard> GraphicsCards { get; set; }
        public DbSet<HDD> HDDs { get; set; }
        public DbSet<Motherboard> Motherboards { get; set; }
        public DbSet<OpticalDrive> OpticalDrives { get; set; }
        public DbSet<PowerSupply> PowerSupplies { get; set; }
        public DbSet<RAM> RAMs { get; set; }
        public DbSet<SoundCard> SoundCards { get; set; }

        public DbSet<Fan> Fans { get; set; }
        public DbSet<Cooler> Coolers { get; set; }
        public DbSet<Liquid> Liquids { get; set; }

        public DbSet<SsdM2> ssdM2s { get; set; }
        public DbSet<SsdSata> ssdSatas { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            FeatureGroup[] featureGroups = new FeatureGroup[]
            {
                new FeatureGroup { Id=1, Name = "Заводские данные" },
                new FeatureGroup { Id=2, Name = "Общие параметры" },
                new FeatureGroup { Id=3, Name = "Форм-фактор и размеры" },
                new FeatureGroup { Id=4, Name = "Чипсет" },
                new FeatureGroup { Id=5, Name = "Память" },
                new FeatureGroup { Id=6, Name = "Контроллеры накопителей" },
                new FeatureGroup { Id=7, Name = "Процессор" },
                new FeatureGroup { Id=8, Name = "Слоты расширения" },
                new FeatureGroup { Id=9, Name = "Задняя панель" },
                new FeatureGroup { Id=10, Name = "Аудио" },
                new FeatureGroup { Id=11, Name = "Сеть" },
                new FeatureGroup { Id=12, Name = "Охлаждение" },
                new FeatureGroup { Id=13, Name = "Питание" },
                new FeatureGroup { Id=14, Name = "Дополнительные параметры" },

                new FeatureGroup { Id=15, Name = "Ядро и архитектура" },
                new FeatureGroup { Id=16, Name = "Частота и возможность разгона" },
                new FeatureGroup { Id=17, Name = "Параметры оперативной памяти" },
                new FeatureGroup { Id=18, Name = "Тепловые характеристики" },
                new FeatureGroup { Id=19, Name = "Графическое ядро" },
                new FeatureGroup { Id=20, Name = "Шина и контроллеры" },
                new FeatureGroup { Id=21, Name = "Команды, инструкции, технологии" },

                new FeatureGroup { Id=22, Name = "Основные параметры" },
                new FeatureGroup { Id=23, Name = "Спецификации видеопроцессора" },
                new FeatureGroup { Id=24, Name = "Спецификации видеопамяти" },
                new FeatureGroup { Id=25, Name = "Вывод изображения" },
                new FeatureGroup { Id=26, Name = "Габариты" },

                new FeatureGroup { Id=27, Name = "Объем и состав комплекта" },
                new FeatureGroup { Id=28, Name = "Быстродействие" },
                new FeatureGroup { Id=29, Name = "Тайминги" },
                new FeatureGroup { Id=30, Name = "Конструкция" },

                new FeatureGroup { Id=31, Name = "Разъемы и интерфейсы" },
                new FeatureGroup { Id=32, Name = "Удобство сборки" },
                new FeatureGroup { Id=33, Name = "Моддинг" },

                new FeatureGroup { Id=34, Name = "Сертификация" },
                new FeatureGroup { Id=35, Name = "Электрические параметры" },
                new FeatureGroup { Id=36, Name = "Кабели и разъемы" },

                new FeatureGroup { Id=37, Name = "Радиатор" },
                new FeatureGroup { Id=38, Name = "Вентилятор" },

                new FeatureGroup { Id=39, Name = "Технические характеристики" },
                new FeatureGroup { Id=40, Name = "Питание и подключение" },

                new FeatureGroup { Id=41, Name = "Внешний вид" },
                new FeatureGroup { Id=42, Name = "Классификация" },
                new FeatureGroup { Id=43, Name = "Совместимость" },
                new FeatureGroup { Id=44, Name = "Водоблок" },

                new FeatureGroup { Id=45, Name = "Конфигурация SSD накопителя" },
                new FeatureGroup { Id=46, Name = "Показатели производительности" },

                new FeatureGroup { Id=47, Name = "Аппаратная составляющая" },
                new FeatureGroup { Id=48, Name = "Плата" },
                new FeatureGroup { Id=49, Name = "Показатели скорости" },
                new FeatureGroup { Id=50, Name = "Надежность" },

                new FeatureGroup { Id=51, Name = "Накопитель" },
                new FeatureGroup { Id=52, Name = "Интерфейс" },
                new FeatureGroup { Id=53, Name = "Механика и надежность" },

                new FeatureGroup { Id=54, Name = "Подключение" },
                new FeatureGroup { Id=55, Name = "Классификация привода" },
                new FeatureGroup { Id=56, Name = "Скорость чтения" },
                new FeatureGroup { Id=57, Name = "Характеристики видео" },
                new FeatureGroup { Id=58, Name = "Входы и выходы" },

                new FeatureGroup { Id=59, Name = "Стандарты" },
                new FeatureGroup { Id=60, Name = "Воспроизведение" },
                new FeatureGroup { Id=61, Name = "Запись" },

                new FeatureGroup { Id=62, Name = "Габариты, вес" }

            };

            modelBuilder.Entity<FeatureGroup>().HasData(featureGroups);

            
            Feature [] features = new Feature[]
            {
                new Feature { Id=1, FeatureGroupId = featureGroups.Where(it => it.Name == "Заводские данные").FirstOrDefault()?.Id, Name="Гарантия" },
                new Feature { Id=2, FeatureGroupId= featureGroups.Where(it => it.Name == "Заводские данные").FirstOrDefault()?.Id, Name="Страна производитель" },
                new Feature { Id=3, FeatureGroupId= featureGroups.Where(it => it.Name == "Заводские данные").FirstOrDefault()?.Id, Name="Модель" },

                new Feature { Id=4, FeatureGroupId= featureGroups.Where(it => it.Name == "Общие параметры").FirstOrDefault()?.Id, Name="Код производителя" },
                new Feature { Id=5, FeatureGroupId= featureGroups.Where(it => it.Name == "Общие параметры").FirstOrDefault()?.Id, Name="Год релиза" },
                new Feature { Id=6, FeatureGroupId= featureGroups.Where(it => it.Name == "Общие параметры").FirstOrDefault()?.Id, Name="Сокет" },
                new Feature { Id=7, FeatureGroupId= featureGroups.Where(it => it.Name == "Общие параметры").FirstOrDefault()?.Id, Name="Система охлаждения в комплекте" },
                new Feature { Id=8, FeatureGroupId= featureGroups.Where(it => it.Name == "Ядро и архитектура").FirstOrDefault()?.Id, Name="Ядро" },
                new Feature { Id=9, FeatureGroupId= featureGroups.Where(it => it.Name == "Ядро и архитектура").FirstOrDefault()?.Id, Name="Техпроцесс" },
                new Feature { Id=10, FeatureGroupId= featureGroups.Where(it => it.Name == "Ядро и архитектура").FirstOrDefault()?.Id, Name="Количество ядер" },
                new Feature { Id=11, FeatureGroupId= featureGroups.Where(it => it.Name == "Ядро и архитектура").FirstOrDefault()?.Id, Name="Максимальное число потоков" },
                new Feature { Id=12, FeatureGroupId= featureGroups.Where(it => it.Name == "Ядро и архитектура").FirstOrDefault()?.Id, Name="Кэш L1 (инструкции)" },
                new Feature { Id=13, FeatureGroupId= featureGroups.Where(it => it.Name == "Ядро и архитектура").FirstOrDefault()?.Id, Name="Кэш L1 (данные)" },
                new Feature { Id=14, FeatureGroupId= featureGroups.Where(it => it.Name == "Ядро и архитектура").FirstOrDefault()?.Id, Name="Объем кэша L2" },
                new Feature { Id=15, FeatureGroupId= featureGroups.Where(it => it.Name == "Ядро и архитектура").FirstOrDefault()?.Id, Name="Объем кэша L3" },
                new Feature { Id=16, FeatureGroupId= featureGroups.Where(it => it.Name == "Частота и возможность разгона").FirstOrDefault()?.Id, Name="Базовая частота процессора" },
                new Feature { Id=17, FeatureGroupId= featureGroups.Where(it => it.Name == "Частота и возможность разгона").FirstOrDefault()?.Id, Name="Максимальная частота процессора" },
                new Feature { Id=18, FeatureGroupId= featureGroups.Where(it => it.Name == "Частота и возможность разгона").FirstOrDefault()?.Id, Name="Максимальная частота процессора в турбо режиме" },
                new Feature { Id=19, FeatureGroupId= featureGroups.Where(it => it.Name == "Частота и возможность разгона").FirstOrDefault()?.Id, Name="Множитель" },
                new Feature { Id=20, FeatureGroupId= featureGroups.Where(it => it.Name == "Частота и возможность разгона").FirstOrDefault()?.Id, Name="Свободный множитель" },
                new Feature { Id=21, FeatureGroupId= featureGroups.Where(it => it.Name == "Параметры оперативной памяти").FirstOrDefault()?.Id, Name="Тип памяти" },
                new Feature { Id=22, FeatureGroupId= featureGroups.Where(it => it.Name == "Параметры оперативной памяти").FirstOrDefault()?.Id, Name="Максимально поддерживаемый объем памяти" },
                new Feature { Id=23, FeatureGroupId= featureGroups.Where(it => it.Name == "Параметры оперативной памяти").FirstOrDefault()?.Id, Name="Количество каналов" },
                new Feature { Id=24, FeatureGroupId= featureGroups.Where(it => it.Name == "Параметры оперативной памяти").FirstOrDefault()?.Id, Name="Минимальная частота оперативной памяти" },
                new Feature { Id=25, FeatureGroupId= featureGroups.Where(it => it.Name == "Параметры оперативной памяти").FirstOrDefault()?.Id, Name="Максимальная частота оперативной памяти" },
                new Feature { Id=26, FeatureGroupId= featureGroups.Where(it => it.Name == "Параметры оперативной памяти").FirstOrDefault()?.Id, Name="Поддержка режима ECC" },
                new Feature { Id=27, FeatureGroupId= featureGroups.Where(it => it.Name == "Тепловые характеристики").FirstOrDefault()?.Id, Name="Тепловыделение (TDP)" },
                new Feature { Id=28, FeatureGroupId= featureGroups.Where(it => it.Name == "Тепловые характеристики").FirstOrDefault()?.Id, Name="Максимальная температура процессора" },
                new Feature { Id=29, FeatureGroupId= featureGroups.Where(it => it.Name == "Графическое ядро").FirstOrDefault()?.Id, Name="Интегрированное графическое ядро" },
                new Feature { Id=30, FeatureGroupId= featureGroups.Where(it => it.Name == "Графическое ядро").FirstOrDefault()?.Id, Name="Модель графического процессора" },
                new Feature { Id=31, FeatureGroupId= featureGroups.Where(it => it.Name == "Шина и контроллеры").FirstOrDefault()?.Id, Name="Системная шина" },
                new Feature { Id=32, FeatureGroupId= featureGroups.Where(it => it.Name == "Шина и контроллеры").FirstOrDefault()?.Id, Name="Пропускная способность шины" },
                new Feature { Id=33, FeatureGroupId= featureGroups.Where(it => it.Name == "Шина и контроллеры").FirstOrDefault()?.Id, Name="Встроенный контроллер PCI Express" },
                new Feature { Id=34, FeatureGroupId= featureGroups.Where(it => it.Name == "Шина и контроллеры").FirstOrDefault()?.Id, Name="Число линий PCI Express" },
                new Feature { Id=35, FeatureGroupId= featureGroups.Where(it => it.Name == "Команды, инструкции, технологии").FirstOrDefault()?.Id, Name="Поддержка 64-битного набора команд" },
                new Feature { Id=36, FeatureGroupId= featureGroups.Where(it => it.Name == "Команды, инструкции, технологии").FirstOrDefault()?.Id, Name="Многопоточность" },
                new Feature { Id=37, FeatureGroupId= featureGroups.Where(it => it.Name == "Команды, инструкции, технологии").FirstOrDefault()?.Id, Name="Технология виртуализации" },
                new Feature { Id=38, FeatureGroupId= featureGroups.Where(it => it.Name == "Команды, инструкции, технологии").FirstOrDefault()?.Id, Name="Технология повышения частоты процессора" },
                new Feature { Id=39, FeatureGroupId= featureGroups.Where(it => it.Name == "Команды, инструкции, технологии").FirstOrDefault()?.Id, Name="Технология энергосбережения" },
                new Feature { Id=40, FeatureGroupId= featureGroups.Where(it => it.Name == "Команды, инструкции, технологии").FirstOrDefault()?.Id, Name="Набор инструкций и команд" },

                new Feature { Id=41, FeatureGroupId= featureGroups.Where(it => it.Name == "Форм-фактор и размеры").FirstOrDefault()?.Id, Name="Форм-фактор" },
                new Feature { Id=42, FeatureGroupId= featureGroups.Where(it => it.Name == "Форм-фактор и размеры").FirstOrDefault()?.Id, Name="Высота" },
                new Feature { Id=43, FeatureGroupId= featureGroups.Where(it => it.Name == "Форм-фактор и размеры").FirstOrDefault()?.Id, Name="Ширина" },
                new Feature { Id=44, FeatureGroupId= featureGroups.Where(it => it.Name == "Процессор").FirstOrDefault()?.Id, Name="Сокет" },
                new Feature { Id=45, FeatureGroupId= featureGroups.Where(it => it.Name == "Процессор").FirstOrDefault()?.Id, Name="Встроенный центральный процессор" },
                new Feature { Id=46, FeatureGroupId= featureGroups.Where(it => it.Name == "Чипсет").FirstOrDefault()?.Id, Name="Чипсет" },
                new Feature { Id=47, FeatureGroupId= featureGroups.Where(it => it.Name == "Чипсет").FirstOrDefault()?.Id, Name="BIOS" },
                new Feature { Id=48, FeatureGroupId= featureGroups.Where(it => it.Name == "Чипсет").FirstOrDefault()?.Id, Name="UEFI" },
                new Feature { Id=49, FeatureGroupId= featureGroups.Where(it => it.Name == "Чипсет").FirstOrDefault()?.Id, Name="Поддержка SLI/CrossFire" },
                new Feature { Id=50, FeatureGroupId= featureGroups.Where(it => it.Name == "Память").FirstOrDefault()?.Id, Name="Форм фактор поддерживаемой памяти" },
                new Feature { Id=51, FeatureGroupId= featureGroups.Where(it => it.Name == "Память").FirstOrDefault()?.Id, Name="Тип поддерживаемой памяти" },
                new Feature { Id=52, FeatureGroupId= featureGroups.Where(it => it.Name == "Память").FirstOrDefault()?.Id, Name="Поддержка режима ЕСС" },
                new Feature { Id=53, FeatureGroupId= featureGroups.Where(it => it.Name == "Память").FirstOrDefault()?.Id, Name="Количество слотов памяти" },
                new Feature { Id=54, FeatureGroupId= featureGroups.Where(it => it.Name == "Память").FirstOrDefault()?.Id, Name="Минимальная частота памяти" },
                new Feature { Id=55, FeatureGroupId= featureGroups.Where(it => it.Name == "Память").FirstOrDefault()?.Id, Name="Максимальная частота памяти" },
                new Feature { Id=56, FeatureGroupId= featureGroups.Where(it => it.Name == "Память").FirstOrDefault()?.Id, Name="Количество каналов памяти" },
                new Feature { Id=57, FeatureGroupId= featureGroups.Where(it => it.Name == "Память").FirstOrDefault()?.Id, Name="Максимальный объем памяти" },
                new Feature { Id=58, FeatureGroupId= featureGroups.Where(it => it.Name == "Контроллеры накопителей").FirstOrDefault()?.Id, Name="Тип и количество портов SATA" },
                new Feature { Id=59, FeatureGroupId= featureGroups.Where(it => it.Name == "Контроллеры накопителей").FirstOrDefault()?.Id, Name="Количество портов SATA Express" },
                new Feature { Id=60, FeatureGroupId= featureGroups.Where(it => it.Name == "Контроллеры накопителей").FirstOrDefault()?.Id, Name="Количество разъемов M.2" },
                new Feature { Id=61, FeatureGroupId= featureGroups.Where(it => it.Name == "Контроллеры накопителей").FirstOrDefault()?.Id, Name="Поддержка NVMe" },
                new Feature { Id=62, FeatureGroupId= featureGroups.Where(it => it.Name == "Контроллеры накопителей").FirstOrDefault()?.Id, Name="Режим работы SATA RAID" },
                new Feature { Id=63, FeatureGroupId= featureGroups.Where(it => it.Name == "Контроллеры накопителей").FirstOrDefault()?.Id, Name="Разъем mSATA" },
                new Feature { Id=64, FeatureGroupId= featureGroups.Where(it => it.Name == "Контроллеры накопителей").FirstOrDefault()?.Id, Name="Контроллер IDE" },
                new Feature { Id=65, FeatureGroupId= featureGroups.Where(it => it.Name == "Слоты расширения").FirstOrDefault()?.Id, Name="Количество слотов PCI-E x16" },
                new Feature { Id=66, FeatureGroupId= featureGroups.Where(it => it.Name == "Слоты расширения").FirstOrDefault()?.Id, Name="Количество слотов PCI-E x8" },
                new Feature { Id=67, FeatureGroupId= featureGroups.Where(it => it.Name == "Слоты расширения").FirstOrDefault()?.Id, Name="Количество слотов PCI-E x4" },
                new Feature { Id=68, FeatureGroupId= featureGroups.Where(it => it.Name == "Слоты расширения").FirstOrDefault()?.Id, Name="Количество слотов PCI-E x1" },
                new Feature { Id=69, FeatureGroupId= featureGroups.Where(it => it.Name == "Слоты расширения").FirstOrDefault()?.Id, Name="Режимы работы несколькихз PCI-E x16 слотов" },
                new Feature { Id=70, FeatureGroupId= featureGroups.Where(it => it.Name == "Слоты расширения").FirstOrDefault()?.Id, Name="Версия PCI Express" },
                new Feature { Id=71, FeatureGroupId= featureGroups.Where(it => it.Name == "Слоты расширения").FirstOrDefault()?.Id, Name="Количество слотов PCI" },
                new Feature { Id=72, FeatureGroupId= featureGroups.Where(it => it.Name == "Задняя панель").FirstOrDefault()?.Id, Name="Внутренние коннекторы USB на плате" },
                new Feature { Id=73, FeatureGroupId= featureGroups.Where(it => it.Name == "Задняя панель").FirstOrDefault()?.Id, Name="Количество и тип USB на задней панели" },
                new Feature { Id=74, FeatureGroupId= featureGroups.Where(it => it.Name == "Задняя панель").FirstOrDefault()?.Id, Name="Видео выходы" },
                new Feature { Id=75, FeatureGroupId= featureGroups.Where(it => it.Name == "Задняя панель").FirstOrDefault()?.Id, Name="Количество аналоговых аудио резъёмов" },
                new Feature { Id=76, FeatureGroupId= featureGroups.Where(it => it.Name == "Задняя панель").FirstOrDefault()?.Id, Name="Цифровые аудио порты (S/PDIF)" },
                new Feature { Id=77, FeatureGroupId= featureGroups.Where(it => it.Name == "Задняя панель").FirstOrDefault()?.Id, Name="Порты PS/2" },
                new Feature { Id=78, FeatureGroupId= featureGroups.Where(it => it.Name == "Задняя панель").FirstOrDefault()?.Id, Name="Другие разъёмы на задней панели" },
                new Feature { Id=79, FeatureGroupId= featureGroups.Where(it => it.Name == "Задняя панель").FirstOrDefault()?.Id, Name="Количество сетевых портов (RJ-45)" },
                new Feature { Id=80, FeatureGroupId= featureGroups.Where(it => it.Name == "Аудио").FirstOrDefault()?.Id, Name="Звук" },
                new Feature { Id=81, FeatureGroupId= featureGroups.Where(it => it.Name == "Аудио").FirstOrDefault()?.Id, Name="Звуковая схема" },
                new Feature { Id=82, FeatureGroupId= featureGroups.Where(it => it.Name == "Аудио").FirstOrDefault()?.Id, Name="Чипсет звукового адаптера" },
                new Feature { Id=83, FeatureGroupId= featureGroups.Where(it => it.Name == "Сеть").FirstOrDefault()?.Id, Name="Чипсет сетевого адаптера" },
                new Feature { Id=84, FeatureGroupId= featureGroups.Where(it => it.Name == "Сеть").FirstOrDefault()?.Id, Name="Скорость сетевого адаптера" },
                new Feature { Id=85, FeatureGroupId= featureGroups.Where(it => it.Name == "Сеть").FirstOrDefault()?.Id, Name="Встроенный адаптер Wi-Fi" },
                new Feature { Id=86, FeatureGroupId= featureGroups.Where(it => it.Name == "Сеть").FirstOrDefault()?.Id, Name="Bluetooth" },
                new Feature { Id=87, FeatureGroupId= featureGroups.Where(it => it.Name == "Охлаждение").FirstOrDefault()?.Id, Name="Разъем питания процессорного кулера" },
                new Feature { Id=88, FeatureGroupId= featureGroups.Where(it => it.Name == "Охлаждение").FirstOrDefault()?.Id, Name="4-pin разъемы для системных вентиляторов" },
                new Feature { Id=89, FeatureGroupId= featureGroups.Where(it => it.Name == "Охлаждение").FirstOrDefault()?.Id, Name="3-pin разъемы для системных вентиляторов" },
                new Feature { Id=90, FeatureGroupId= featureGroups.Where(it => it.Name == "Питание").FirstOrDefault()?.Id, Name="Основной разъем питания процессора" },
                new Feature { Id=91, FeatureGroupId= featureGroups.Where(it => it.Name == "Питание").FirstOrDefault()?.Id, Name="Количество фаз питания" },
                new Feature { Id=92, FeatureGroupId= featureGroups.Where(it => it.Name == "Дополнительные параметры").FirstOrDefault()?.Id, Name="Подсветка элементов платы" },
                new Feature { Id=93, FeatureGroupId= featureGroups.Where(it => it.Name == "Дополнительные параметры").FirstOrDefault()?.Id, Name="Разъем светодиодов 3-Pin(+5V-D-G)" },
                new Feature { Id=94, FeatureGroupId= featureGroups.Where(it => it.Name == "Дополнительные параметры").FirstOrDefault()?.Id, Name="Разъемм светодиодов 4-Pin(12V-G-R-B)" },
                new Feature { Id=95, FeatureGroupId= featureGroups.Where(it => it.Name == "Дополнительные параметры").FirstOrDefault()?.Id, Name="Интерфейс LPT" },
                new Feature { Id=96, FeatureGroupId= featureGroups.Where(it => it.Name == "Дополнительные параметры").FirstOrDefault()?.Id, Name="Комплектация" },
                new Feature { Id=97, FeatureGroupId= featureGroups.Where(it => it.Name == "Дополнительные параметры").FirstOrDefault()?.Id, Name="Особенности, дополнительно" },

                new Feature { Id=98, FeatureGroupId= featureGroups.Where(it => it.Name == "Основные параметры").FirstOrDefault()?.Id, Name="Линейка графических процессоров" },
                new Feature { Id=99, FeatureGroupId= featureGroups.Where(it => it.Name == "Основные параметры").FirstOrDefault()?.Id, Name="Графический процессор" },
                new Feature { Id=100, FeatureGroupId= featureGroups.Where(it => it.Name == "Основные параметры").FirstOrDefault()?.Id, Name="Поддержка стандартов" },
                new Feature { Id=101, FeatureGroupId= featureGroups.Where(it => it.Name == "Спецификации видеопроцессора").FirstOrDefault()?.Id, Name="Количество видеочипов" },
                new Feature { Id=102, FeatureGroupId= featureGroups.Where(it => it.Name == "Спецификации видеопроцессора").FirstOrDefault()?.Id, Name="Техпроцесс" },
                new Feature { Id=103, FeatureGroupId= featureGroups.Where(it => it.Name == "Спецификации видеопроцессора").FirstOrDefault()?.Id, Name="Штатная частота работы видеочипа" },
                new Feature { Id=104, FeatureGroupId= featureGroups.Where(it => it.Name == "Спецификации видеопроцессора").FirstOrDefault()?.Id, Name="Турбочастота" },
                new Feature { Id=105, FeatureGroupId= featureGroups.Where(it => it.Name == "Спецификации видеопроцессора").FirstOrDefault()?.Id, Name="Количество универсальных процессоров" },
                new Feature { Id=106, FeatureGroupId= featureGroups.Where(it => it.Name == "Спецификации видеопроцессора").FirstOrDefault()?.Id, Name="Число текстурных блоков" },
                new Feature { Id=107, FeatureGroupId= featureGroups.Where(it => it.Name == "Спецификации видеопроцессора").FirstOrDefault()?.Id, Name="Число блоков растеризации" },
                new Feature { Id=108, FeatureGroupId= featureGroups.Where(it => it.Name == "Спецификации видеопроцессора").FirstOrDefault()?.Id, Name="Версия шейдеров" },
                new Feature { Id=109, FeatureGroupId= featureGroups.Where(it => it.Name == "Спецификации видеопроцессора").FirstOrDefault()?.Id, Name="Максимальная температура процессора" },
                new Feature { Id=110, FeatureGroupId= featureGroups.Where(it => it.Name == "Спецификации видеопроцессора").FirstOrDefault()?.Id, Name="Поддержка трассировки лучей" },
                new Feature { Id=111, FeatureGroupId= featureGroups.Where(it => it.Name == "Спецификации видеопамяти").FirstOrDefault()?.Id, Name="Объем видеопамяти" },
                new Feature { Id=112, FeatureGroupId= featureGroups.Where(it => it.Name == "Спецификации видеопамяти").FirstOrDefault()?.Id, Name="Тип памяти" },
                new Feature { Id=113, FeatureGroupId= featureGroups.Where(it => it.Name == "Спецификации видеопамяти").FirstOrDefault()?.Id, Name="Эффективная частота памяти (МГц)" },
                new Feature { Id=114, FeatureGroupId= featureGroups.Where(it => it.Name == "Спецификации видеопамяти").FirstOrDefault()?.Id, Name="Разрядность шины памяти" },
                new Feature { Id=115, FeatureGroupId= featureGroups.Where(it => it.Name == "Спецификации видеопамяти").FirstOrDefault()?.Id, Name="Максимальная пропускная способность памяти" },
                new Feature { Id=116, FeatureGroupId= featureGroups.Where(it => it.Name == "Подключение").FirstOrDefault()?.Id, Name="Интерфейс подключения" },
                new Feature { Id=117, FeatureGroupId= featureGroups.Where(it => it.Name == "Подключение").FirstOrDefault()?.Id, Name="Версия PCI Express" },
                new Feature { Id=118, FeatureGroupId= featureGroups.Where(it => it.Name == "Подключение").FirstOrDefault()?.Id, Name="Поддержка мультипроцессорной конфигурации" },
                new Feature { Id=119, FeatureGroupId= featureGroups.Where(it => it.Name == "Вывод изображения").FirstOrDefault()?.Id, Name="Количество подключаемых одновременно мониторов" },
                new Feature { Id=120, FeatureGroupId= featureGroups.Where(it => it.Name == "Вывод изображения").FirstOrDefault()?.Id, Name="Видео разъемы" },
                new Feature { Id=121, FeatureGroupId= featureGroups.Where(it => it.Name == "Вывод изображения").FirstOrDefault()?.Id, Name="Максимальное разрешение" },
                new Feature { Id=122, FeatureGroupId= featureGroups.Where(it => it.Name == "Питание").FirstOrDefault()?.Id, Name="Необходимость дополнительного питания" },
                new Feature { Id=123, FeatureGroupId= featureGroups.Where(it => it.Name == "Питание").FirstOrDefault()?.Id, Name="Разъемы дополнительного питания" },
                new Feature { Id=124, FeatureGroupId= featureGroups.Where(it => it.Name == "Питание").FirstOrDefault()?.Id, Name="Максимальное энергопотребление" },
                new Feature { Id=125, FeatureGroupId= featureGroups.Where(it => it.Name == "Питание").FirstOrDefault()?.Id, Name="Рекомендуемый блок питания" },
                new Feature { Id=126, FeatureGroupId= featureGroups.Where(it => it.Name == "Система охлаждения").FirstOrDefault()?.Id, Name="Тип охлаждения" },
                new Feature { Id=127, FeatureGroupId= featureGroups.Where(it => it.Name == "Система охлаждения").FirstOrDefault()?.Id, Name="Тип и количество установленных вентиляторов" },
                new Feature { Id=128, FeatureGroupId= featureGroups.Where(it => it.Name == "Габариты").FirstOrDefault()?.Id, Name="Низкопрофильная карта (Low Profile)" },
                new Feature { Id=129, FeatureGroupId= featureGroups.Where(it => it.Name == "Габариты").FirstOrDefault()?.Id, Name="Количество занимаемых слотов расширения" },
                new Feature { Id=130, FeatureGroupId= featureGroups.Where(it => it.Name == "Габариты").FirstOrDefault()?.Id, Name="Длина видеокарты " },
                new Feature { Id=131, FeatureGroupId= featureGroups.Where(it => it.Name == "Дополнительно").FirstOrDefault()?.Id, Name="Подсветка элементов видеокарты " },

                new Feature { Id=132, FeatureGroupId= featureGroups.Where(it => it.Name == "Объем и состав комплекта").FirstOrDefault()?.Id, Name="Тип памяти " },
                new Feature { Id=133, FeatureGroupId= featureGroups.Where(it => it.Name == "Объем и состав комплекта").FirstOrDefault()?.Id, Name="Форм-фактор памяти" },
                new Feature { Id=134, FeatureGroupId= featureGroups.Where(it => it.Name == "Объем и состав комплекта").FirstOrDefault()?.Id, Name="Регистровая память" },
                new Feature { Id=135, FeatureGroupId= featureGroups.Where(it => it.Name == "Объем и состав комплекта").FirstOrDefault()?.Id, Name="ECC-память" },
                new Feature { Id=136, FeatureGroupId= featureGroups.Where(it => it.Name == "Объем и состав комплекта").FirstOrDefault()?.Id, Name="Объем одного модуля памяти" },
                new Feature { Id=137, FeatureGroupId= featureGroups.Where(it => it.Name == "Объем и состав комплекта").FirstOrDefault()?.Id, Name="Количество модулей в комплекте" },
                new Feature { Id=138, FeatureGroupId= featureGroups.Where(it => it.Name == "Быстродействие").FirstOrDefault()?.Id, Name="Тактовая частота" },
                new Feature { Id=139, FeatureGroupId= featureGroups.Where(it => it.Name == "Быстродействие").FirstOrDefault()?.Id, Name="Пропускная способность" },
                new Feature { Id=140, FeatureGroupId= featureGroups.Where(it => it.Name == "Быстродействие").FirstOrDefault()?.Id, Name="Профили Intel XMP" },
                new Feature { Id=141, FeatureGroupId= featureGroups.Where(it => it.Name == "Быстродействие").FirstOrDefault()?.Id, Name="Поддерживаемые режимы работы" },
                new Feature { Id=142, FeatureGroupId= featureGroups.Where(it => it.Name == "Тайминги").FirstOrDefault()?.Id, Name="CAS Latency (CL)" },
                new Feature { Id=143, FeatureGroupId= featureGroups.Where(it => it.Name == "Тайминги").FirstOrDefault()?.Id, Name="RAS to CAS Delay (tRCD)" },
                new Feature { Id=144, FeatureGroupId= featureGroups.Where(it => it.Name == "Тайминги").FirstOrDefault()?.Id, Name="Row Precharge Delay (tRP)" },
                new Feature { Id=145, FeatureGroupId= featureGroups.Where(it => it.Name == "Конструкция").FirstOrDefault()?.Id, Name="Наличие радиатора" },
                new Feature { Id=146, FeatureGroupId= featureGroups.Where(it => it.Name == "Конструкция").FirstOrDefault()?.Id, Name="Подсветка элементов платы" },
                new Feature { Id=147, FeatureGroupId= featureGroups.Where(it => it.Name == "Конструкция").FirstOrDefault()?.Id, Name="Высота" },
                new Feature { Id=148, FeatureGroupId= featureGroups.Where(it => it.Name == "Конструкция").FirstOrDefault()?.Id, Name="Низкопрофильная (Low Profile)" },
                new Feature { Id=149, FeatureGroupId= featureGroups.Where(it => it.Name == "Дополнительно").FirstOrDefault()?.Id, Name="Напряжение питания" },

                new Feature { Id=150, FeatureGroupId= featureGroups.Where(it => it.Name == "Сертификация").FirstOrDefault()?.Id, Name="Версия ATX12V" },
                new Feature { Id=151, FeatureGroupId= featureGroups.Where(it => it.Name == "Сертификация").FirstOrDefault()?.Id, Name="Поддержка EPS12V" },
                new Feature { Id=152, FeatureGroupId= featureGroups.Where(it => it.Name == "Сертификация").FirstOrDefault()?.Id, Name="Сертификат 80 PLUS" },
                new Feature { Id=153, FeatureGroupId= featureGroups.Where(it => it.Name == "Сертификация").FirstOrDefault()?.Id, Name="Корректор коэффициента мощности (PFC) " },
                new Feature { Id=154, FeatureGroupId= featureGroups.Where(it => it.Name == "Электрические параметры").FirstOrDefault()?.Id, Name="Мощность (номинал)" },
                new Feature { Id=155, FeatureGroupId= featureGroups.Where(it => it.Name == "Электрические параметры").FirstOrDefault()?.Id, Name="Мощность по линии 12 В" },
                new Feature { Id=156, FeatureGroupId= featureGroups.Where(it => it.Name == "Электрические параметры").FirstOrDefault()?.Id, Name="Ток по линии +12 В" },
                new Feature { Id=157, FeatureGroupId= featureGroups.Where(it => it.Name == "Электрические параметры").FirstOrDefault()?.Id, Name="Ток по линии +3.3 В" },
                new Feature { Id=158, FeatureGroupId= featureGroups.Where(it => it.Name == "Электрические параметры").FirstOrDefault()?.Id, Name="Ток по линии +5 В" },
                new Feature { Id=159, FeatureGroupId= featureGroups.Where(it => it.Name == "Электрические параметры").FirstOrDefault()?.Id, Name="Ток дежурного источника (+5 В Standby)" },
                new Feature { Id=160, FeatureGroupId= featureGroups.Where(it => it.Name == "Электрические параметры").FirstOrDefault()?.Id, Name="Ток по линии -12 В" },
                new Feature { Id=161, FeatureGroupId= featureGroups.Where(it => it.Name == "Электрические параметры").FirstOrDefault()?.Id, Name="Диапазон входного напряжения сети" },
                new Feature { Id=162, FeatureGroupId= featureGroups.Where(it => it.Name == "Кабели и разъемы").FirstOrDefault()?.Id, Name="Отстегивающиеся кабели" },
                new Feature { Id=163, FeatureGroupId= featureGroups.Where(it => it.Name == "Кабели и разъемы").FirstOrDefault()?.Id, Name="Основной разъем питания" },
                new Feature { Id=164, FeatureGroupId= featureGroups.Where(it => it.Name == "Кабели и разъемы").FirstOrDefault()?.Id, Name="Разъемы для питания процессора (CPU)" },
                new Feature { Id=165, FeatureGroupId= featureGroups.Where(it => it.Name == "Кабели и разъемы").FirstOrDefault()?.Id, Name="Разъемы для питания видеокарты (PCI-E)" },
                new Feature { Id=166, FeatureGroupId= featureGroups.Where(it => it.Name == "Кабели и разъемы").FirstOrDefault()?.Id, Name="Количество разъемов 15-pin SATA" },
                new Feature { Id=167, FeatureGroupId= featureGroups.Where(it => it.Name == "Кабели и разъемы").FirstOrDefault()?.Id, Name="Количество разъемов 4-pin Molex" },
                new Feature { Id=168, FeatureGroupId= featureGroups.Where(it => it.Name == "Кабели и разъемы").FirstOrDefault()?.Id, Name="Количество разъемов 4-pin Floppy" },
                new Feature { Id=169, FeatureGroupId= featureGroups.Where(it => it.Name == "Кабели и разъемы").FirstOrDefault()?.Id, Name="Длина основного кабеля питания" },
                new Feature { Id=170, FeatureGroupId= featureGroups.Where(it => it.Name == "Система охлаждения").FirstOrDefault()?.Id, Name="Система охлаждения" },
                new Feature { Id=171, FeatureGroupId= featureGroups.Where(it => it.Name == "Система охлаждения").FirstOrDefault()?.Id, Name="Размеры вентиляторов" },
                new Feature { Id=172, FeatureGroupId= featureGroups.Where(it => it.Name == "Моддинг").FirstOrDefault()?.Id, Name="Цвет подсветки " },
                new Feature { Id=173, FeatureGroupId= featureGroups.Where(it => it.Name == "Моддинг").FirstOrDefault()?.Id, Name="Оплетка проводов" },

                new Feature { Id=174, FeatureGroupId= featureGroups.Where(it => it.Name == "Габариты, вес").FirstOrDefault()?.Id, Name="Длина" },
                new Feature { Id=175, FeatureGroupId= featureGroups.Where(it => it.Name == "Габариты, вес").FirstOrDefault()?.Id, Name="Ширина" },
                new Feature { Id=176, FeatureGroupId= featureGroups.Where(it => it.Name == "Габариты, вес").FirstOrDefault()?.Id, Name="Высота" },
                new Feature { Id=177, FeatureGroupId= featureGroups.Where(it => it.Name == "Габариты, вес").FirstOrDefault()?.Id, Name="Вес" },

                new Feature { Id=178, FeatureGroupId= featureGroups.Where(it => it.Name == "Форм-фактор и габариты").FirstOrDefault()?.Id, Name="Форм-фактор совместимых плат" },
                new Feature { Id=179, FeatureGroupId= featureGroups.Where(it => it.Name == "Форм-фактор и габариты").FirstOrDefault()?.Id, Name="Типоразмер корпуса" },
                new Feature { Id=180, FeatureGroupId= featureGroups.Where(it => it.Name == "Форм-фактор и габариты").FirstOrDefault()?.Id, Name="Корпус для HTPC" },
                new Feature { Id=181, FeatureGroupId= featureGroups.Where(it => it.Name == "Блок питания").FirstOrDefault()?.Id, Name="Встроенный БП" },
                new Feature { Id=182, FeatureGroupId= featureGroups.Where(it => it.Name == "Блок питания").FirstOrDefault()?.Id, Name="Размещение блока питания" },
                new Feature { Id=183, FeatureGroupId= featureGroups.Where(it => it.Name == "Блок питания").FirstOrDefault()?.Id, Name="Форм-фактор совместимых блоков питания" },
                new Feature { Id=184, FeatureGroupId= featureGroups.Where(it => it.Name == "Конструкция").FirstOrDefault()?.Id, Name="Док-станция для HDD/SSD" },
                new Feature { Id=185, FeatureGroupId= featureGroups.Where(it => it.Name == "Конструкция").FirstOrDefault()?.Id, Name="Материал корпуса" },
                new Feature { Id=186, FeatureGroupId= featureGroups.Where(it => it.Name == "Конструкция").FirstOrDefault()?.Id, Name="Толщина металла" },
                new Feature { Id=187, FeatureGroupId= featureGroups.Where(it => it.Name == "Конструкция").FirstOrDefault()?.Id, Name="Положение корзин накопителей" },
                new Feature { Id=188, FeatureGroupId= featureGroups.Where(it => it.Name == "Конструкция").FirstOrDefault()?.Id, Name="Отсеки для 2.5 накопителей" },
                new Feature { Id=189, FeatureGroupId= featureGroups.Where(it => it.Name == "Конструкция").FirstOrDefault()?.Id, Name="Количество отсеков 2.5 накопителей" },
                new Feature { Id=190, FeatureGroupId= featureGroups.Where(it => it.Name == "Конструкция").FirstOrDefault()?.Id, Name="Число внутренних отсеков 3.5" },
                new Feature { Id=191, FeatureGroupId= featureGroups.Where(it => it.Name == "Конструкция").FirstOrDefault()?.Id, Name="Число внешних отсеков 3.5" },
                new Feature { Id=192, FeatureGroupId= featureGroups.Where(it => it.Name == "Конструкция").FirstOrDefault()?.Id, Name="Число отсеков 5.25" },
                new Feature { Id=193, FeatureGroupId= featureGroups.Where(it => it.Name == "Конструкция").FirstOrDefault()?.Id, Name="Количество слотов расширения" },
                new Feature { Id=194, FeatureGroupId= featureGroups.Where(it => it.Name == "Конструкция").FirstOrDefault()?.Id, Name="Максимальная длина устанавливаемой видеокарты" },
                new Feature { Id=195, FeatureGroupId= featureGroups.Where(it => it.Name == "Конструкция").FirstOrDefault()?.Id, Name="Максимальная высота процессорного кулера" },
                new Feature { Id=196, FeatureGroupId= featureGroups.Where(it => it.Name == "Конструкция").FirstOrDefault()?.Id, Name="Малошумные и антивибрационные корпуса" },
                new Feature { Id=197, FeatureGroupId= featureGroups.Where(it => it.Name == "Охлаждение").FirstOrDefault()?.Id, Name="Вентиляторы в комплекте" },
                new Feature { Id=198, FeatureGroupId= featureGroups.Where(it => it.Name == "Охлаждение").FirstOrDefault()?.Id, Name="Поддержка фронтальных вентиляторов" },
                new Feature { Id=199, FeatureGroupId= featureGroups.Where(it => it.Name == "Охлаждение").FirstOrDefault()?.Id, Name="Поддержка тыловых вентиляторов" },
                new Feature { Id=200, FeatureGroupId= featureGroups.Where(it => it.Name == "Охлаждение").FirstOrDefault()?.Id, Name="Поддержка верхних вентиляторов" },
                new Feature { Id=201, FeatureGroupId= featureGroups.Where(it => it.Name == "Охлаждение").FirstOrDefault()?.Id, Name="Поддержка нижних вентиляторов" },
                new Feature { Id=202, FeatureGroupId= featureGroups.Where(it => it.Name == "Охлаждение").FirstOrDefault()?.Id, Name="Поддержка боковых вентиляторов" },
                new Feature { Id=203, FeatureGroupId= featureGroups.Where(it => it.Name == "Охлаждение").FirstOrDefault()?.Id, Name="Возможность установки системы жидкостного охлаждения" },
                new Feature { Id=204, FeatureGroupId= featureGroups.Where(it => it.Name == "Охлаждение").FirstOrDefault()?.Id, Name="Блок управления вентиляторами" },
                new Feature { Id=205, FeatureGroupId= featureGroups.Where(it => it.Name == "Разъемы и интерфейсы лицевой панели").FirstOrDefault()?.Id, Name="Расположение I/O панели" },
                new Feature { Id=206, FeatureGroupId= featureGroups.Where(it => it.Name == "Разъемы и интерфейсы лицевой панели").FirstOrDefault()?.Id, Name="Количество и тип USB портов" },
                new Feature { Id=207, FeatureGroupId= featureGroups.Where(it => it.Name == "Разъемы и интерфейсы лицевой панели").FirstOrDefault()?.Id, Name="Аудио разъемы" },
                new Feature { Id=208, FeatureGroupId= featureGroups.Where(it => it.Name == "Разъемы и интерфейсы лицевой панели").FirstOrDefault()?.Id, Name="Интерфейсы eSATA" },
                new Feature { Id=209, FeatureGroupId= featureGroups.Where(it => it.Name == "Разъемы и интерфейсы лицевой панели").FirstOrDefault()?.Id, Name="Встроенный кард-ридер" },
                new Feature { Id=210, FeatureGroupId= featureGroups.Where(it => it.Name == "Удобство сборки").FirstOrDefault()?.Id, Name="Безвинтовое крепление в отсеках 3,5" },
                new Feature { Id=211, FeatureGroupId= featureGroups.Where(it => it.Name == "Удобство сборки").FirstOrDefault()?.Id, Name="Безвинтовое крепление в отсеках 5,25" },
                new Feature { Id=212, FeatureGroupId= featureGroups.Where(it => it.Name == "Удобство сборки").FirstOrDefault()?.Id, Name="Безвинтовое крепление в слотах расширения" },
                new Feature { Id=213, FeatureGroupId= featureGroups.Where(it => it.Name == "Удобство сборки").FirstOrDefault()?.Id, Name="Прокладка кабелей за задней стенкой" },
                new Feature { Id=214, FeatureGroupId= featureGroups.Where(it => it.Name == "Удобство сборки").FirstOrDefault()?.Id, Name="Вырез в районе крепления кулера CPU" },
                new Feature { Id=215, FeatureGroupId= featureGroups.Where(it => it.Name == "Моддинг").FirstOrDefault()?.Id, Name="Наличие окна на боковой стенке" },
                new Feature { Id=216, FeatureGroupId= featureGroups.Where(it => it.Name == "Моддинг").FirstOrDefault()?.Id, Name="Подсветка" },
                new Feature { Id=217, FeatureGroupId= featureGroups.Where(it => it.Name == "Моддинг").FirstOrDefault()?.Id, Name="Пылевой фильтр" },
                new Feature { Id=218, FeatureGroupId= featureGroups.Where(it => it.Name == "Дополнительная информация").FirstOrDefault()?.Id, Name="Возможность закрывать крышку на замок" },

                new Feature { Id=219, FeatureGroupId= featureGroups.Where(it => it.Name == "Радиатор").FirstOrDefault()?.Id, Name="Рассеиваемая мощность" },
                new Feature { Id=220, FeatureGroupId= featureGroups.Where(it => it.Name == "Радиатор").FirstOrDefault()?.Id, Name="Тип конструкции" },
                new Feature { Id=221, FeatureGroupId= featureGroups.Where(it => it.Name == "Радиатор").FirstOrDefault()?.Id, Name="Материал основания" },
                new Feature { Id=222, FeatureGroupId= featureGroups.Where(it => it.Name == "Радиатор").FirstOrDefault()?.Id, Name="Материал радиатора" },
                new Feature { Id=223, FeatureGroupId= featureGroups.Where(it => it.Name == "Радиатор").FirstOrDefault()?.Id, Name="Количество тепловых трубок" },
                new Feature { Id=224, FeatureGroupId= featureGroups.Where(it => it.Name == "Радиатор").FirstOrDefault()?.Id, Name="Никелированное покрытие" },
                new Feature { Id=225, FeatureGroupId= featureGroups.Where(it => it.Name == "Вентилятор").FirstOrDefault()?.Id, Name="Разъем для подключения вентиляторов" },
                new Feature { Id=226, FeatureGroupId= featureGroups.Where(it => it.Name == "Вентилятор").FirstOrDefault()?.Id, Name="Количество вентиляторов в комплекте" },
                new Feature { Id=227, FeatureGroupId= featureGroups.Where(it => it.Name == "Вентилятор").FirstOrDefault()?.Id, Name="Максимальное число устанавливаемых вентиляторов " },
                new Feature { Id=228, FeatureGroupId= featureGroups.Where(it => it.Name == "Вентилятор").FirstOrDefault()?.Id, Name="Размеры комплектных вентиляторов " },
                new Feature { Id=229, FeatureGroupId= featureGroups.Where(it => it.Name == "Вентилятор").FirstOrDefault()?.Id, Name="Максимальная скорость вращения" },
                new Feature { Id=230, FeatureGroupId= featureGroups.Where(it => it.Name == "Вентилятор").FirstOrDefault()?.Id, Name="Минимальная скорость вращения" },
                new Feature { Id=231, FeatureGroupId= featureGroups.Where(it => it.Name == "Вентилятор").FirstOrDefault()?.Id, Name="Регулировка скорости вращения" },
                new Feature { Id=232, FeatureGroupId= featureGroups.Where(it => it.Name == "Вентилятор").FirstOrDefault()?.Id, Name="Максимальный воздушный поток" },
                new Feature { Id=233, FeatureGroupId= featureGroups.Where(it => it.Name == "Вентилятор").FirstOrDefault()?.Id, Name="Максимальный уровень шума" },
                new Feature { Id=234, FeatureGroupId= featureGroups.Where(it => it.Name == "Вентилятор").FirstOrDefault()?.Id, Name="Тип подсветки вентилятора" },
                new Feature { Id=235, FeatureGroupId= featureGroups.Where(it => it.Name == "Вентилятор").FirstOrDefault()?.Id, Name="Цвет подсветки вентилятора" },
                new Feature { Id=236, FeatureGroupId= featureGroups.Where(it => it.Name == "Вентилятор").FirstOrDefault()?.Id, Name="Источник подсветки" },
                new Feature { Id=237, FeatureGroupId= featureGroups.Where(it => it.Name == "Вентилятор").FirstOrDefault()?.Id, Name="Цвет вентилятора" },
                new Feature { Id=238, FeatureGroupId= featureGroups.Where(it => it.Name == "Дополнительно").FirstOrDefault()?.Id, Name="Термопаста в комплекте" },

                new Feature { Id=239, FeatureGroupId= featureGroups.Where(it => it.Name == "Общие параметры").FirstOrDefault()?.Id, Name="Цвет каркаса" },
                new Feature { Id=240, FeatureGroupId= featureGroups.Where(it => it.Name == "Общие параметры").FirstOrDefault()?.Id, Name="Цвет крыльчатки" },
                new Feature { Id=241, FeatureGroupId= featureGroups.Where(it => it.Name == "Общие параметры").FirstOrDefault()?.Id, Name="Количество вентиляторов в комплекте" },
                new Feature { Id=242, FeatureGroupId= featureGroups.Where(it => it.Name == "Конструкция").FirstOrDefault()?.Id, Name="Размер вентилятора" },
                new Feature { Id=243, FeatureGroupId= featureGroups.Where(it => it.Name == "Конструкция").FirstOrDefault()?.Id, Name="Толщина вентилятора" },
                new Feature { Id=244, FeatureGroupId= featureGroups.Where(it => it.Name == "Конструкция").FirstOrDefault()?.Id, Name="Тип подшипника" },
                new Feature { Id=245, FeatureGroupId= featureGroups.Where(it => it.Name == "Конструкция").FirstOrDefault()?.Id, Name="Количество лопастей вентилятора" },
                new Feature { Id=246, FeatureGroupId= featureGroups.Where(it => it.Name == "Конструкция").FirstOrDefault()?.Id, Name="Цвет подсветки вентилятора" },
                new Feature { Id=247, FeatureGroupId= featureGroups.Where(it => it.Name == "Конструкция").FirstOrDefault()?.Id, Name="Длина кабеля" },
                new Feature { Id=248, FeatureGroupId= featureGroups.Where(it => it.Name == "Конструкция").FirstOrDefault()?.Id, Name="Тип подсветки" },
                new Feature { Id=249, FeatureGroupId= featureGroups.Where(it => it.Name == "Технические характеристики").FirstOrDefault()?.Id, Name="Воздушный поток на минимальной скорости" },
                new Feature { Id=250, FeatureGroupId= featureGroups.Where(it => it.Name == "Технические характеристики").FirstOrDefault()?.Id, Name="Воздушный поток на максимальной скорости" },
                new Feature { Id=251, FeatureGroupId= featureGroups.Where(it => it.Name == "Технические характеристики").FirstOrDefault()?.Id, Name="Время безотказной работы" },
                new Feature { Id=252, FeatureGroupId= featureGroups.Where(it => it.Name == "Питание и подключение").FirstOrDefault()?.Id, Name="Тип разъёма питания вентилятора" },
                new Feature { Id=253, FeatureGroupId= featureGroups.Where(it => it.Name == "Питание и подключение").FirstOrDefault()?.Id, Name="Стартовое напряжение" },
                new Feature { Id=254, FeatureGroupId= featureGroups.Where(it => it.Name == "Питание и подключение").FirstOrDefault()?.Id, Name="Регулировка оборотов" },
                new Feature { Id=255, FeatureGroupId= featureGroups.Where(it => it.Name == "Питание и подключение").FirstOrDefault()?.Id, Name="Максимальный ток" },
                new Feature { Id=256, FeatureGroupId= featureGroups.Where(it => it.Name == "Питание и подключение").FirstOrDefault()?.Id, Name="Максимальное рабочее напряжение" },
                new Feature { Id=257, FeatureGroupId= featureGroups.Where(it => it.Name == "Питание и подключение").FirstOrDefault()?.Id, Name="Переходники в комплекте" },

                new Feature { Id=258, FeatureGroupId= featureGroups.Where(it => it.Name == "Внешний вид").FirstOrDefault()?.Id, Name="Прозрачные трубки" },
                new Feature { Id=259, FeatureGroupId= featureGroups.Where(it => it.Name == "Радиатор").FirstOrDefault()?.Id, Name="Монтажный типоразмер радиатора" },
                new Feature { Id=260, FeatureGroupId= featureGroups.Where(it => it.Name == "Водоблок").FirstOrDefault()?.Id, Name="Материал водоблока" },
                new Feature { Id=261, FeatureGroupId= featureGroups.Where(it => it.Name == "Водоблок").FirstOrDefault()?.Id, Name="Размеры водоблока" },
                new Feature { Id=262, FeatureGroupId= featureGroups.Where(it => it.Name == "Дополнительно").FirstOrDefault()?.Id, Name="Тип коннектора питания помпы" },
                new Feature { Id=263, FeatureGroupId= featureGroups.Where(it => it.Name == "Дополнительно").FirstOrDefault()?.Id, Name="Защита от протечки " },
                new Feature { Id=264, FeatureGroupId= featureGroups.Where(it => it.Name == "Дополнительно").FirstOrDefault()?.Id, Name="Регулировка скорости вращения вентилятора" },

                new Feature { Id=265, FeatureGroupId= featureGroups.Where(it => it.Name == "Основные характеристики").FirstOrDefault()?.Id, Name="Объем накопителя" },
                new Feature { Id=266, FeatureGroupId= featureGroups.Where(it => it.Name == "Основные характеристики").FirstOrDefault()?.Id, Name="Физический интерфейс" },
                new Feature { Id=267, FeatureGroupId= featureGroups.Where(it => it.Name == "Основные характеристики").FirstOrDefault()?.Id, Name="Шифрование данных" },
                new Feature { Id=268, FeatureGroupId= featureGroups.Where(it => it.Name == "Конфигурация SSD накопителя").FirstOrDefault()?.Id, Name="Контроллер" },
                new Feature { Id=269, FeatureGroupId= featureGroups.Where(it => it.Name == "Конфигурация SSD накопителя").FirstOrDefault()?.Id, Name="Тип чипов памяти" },
                new Feature { Id=270, FeatureGroupId= featureGroups.Where(it => it.Name == "Конфигурация SSD накопителя").FirstOrDefault()?.Id, Name="Количество бит на ячейку" },
                new Feature { Id=271, FeatureGroupId= featureGroups.Where(it => it.Name == "Конфигурация SSD накопителя").FirstOrDefault()?.Id, Name="Структура памяти" },
                new Feature { Id=272, FeatureGroupId= featureGroups.Where(it => it.Name == "Показатели производительности").FirstOrDefault()?.Id, Name="NVMe" },
                new Feature { Id=273, FeatureGroupId= featureGroups.Where(it => it.Name == "Показатели производительности").FirstOrDefault()?.Id, Name="Максимальная скорость записи (сжатые данные)" },
                new Feature { Id=274, FeatureGroupId= featureGroups.Where(it => it.Name == "Показатели производительности").FirstOrDefault()?.Id, Name="Максимальная скорость чтения (сжатые данные)" },
                new Feature { Id=275, FeatureGroupId= featureGroups.Where(it => it.Name == "Показатели производительности").FirstOrDefault()?.Id, Name="Скорость произвольной записи 4 Кб файлов (QD32)" },
                new Feature { Id=276, FeatureGroupId= featureGroups.Where(it => it.Name == "Показатели производительности").FirstOrDefault()?.Id, Name="Скорость произвольного чтения 4 Кб файлов (QD32)" },
                new Feature { Id=277, FeatureGroupId= featureGroups.Where(it => it.Name == "Дополнительная информация").FirstOrDefault()?.Id, Name="Ресурс работы, TBW" },

                new Feature { Id=278, FeatureGroupId= featureGroups.Where(it => it.Name == "Аппаратная составляющая").FirstOrDefault()?.Id, Name="Контроллер" },
                new Feature { Id=279, FeatureGroupId= featureGroups.Where(it => it.Name == "Аппаратная составляющая").FirstOrDefault()?.Id, Name="Тип чипов памяти" },
                new Feature { Id=280, FeatureGroupId= featureGroups.Where(it => it.Name == "Аппаратная составляющая").FirstOrDefault()?.Id, Name="Количество бит на ячейку" },
                new Feature { Id=281, FeatureGroupId= featureGroups.Where(it => it.Name == "Аппаратная составляющая").FirstOrDefault()?.Id, Name="Структура памяти" },
                new Feature { Id=282, FeatureGroupId= featureGroups.Where(it => it.Name == "Плата").FirstOrDefault()?.Id, Name="Форм-фактор" },
                new Feature { Id=283, FeatureGroupId= featureGroups.Where(it => it.Name == "Плата").FirstOrDefault()?.Id, Name="Длина" },
                new Feature { Id=284, FeatureGroupId= featureGroups.Where(it => it.Name == "Плата").FirstOrDefault()?.Id, Name="Ширина" },
                new Feature { Id=285, FeatureGroupId= featureGroups.Where(it => it.Name == "Плата").FirstOrDefault()?.Id, Name="Толщина" },
                new Feature { Id=286, FeatureGroupId= featureGroups.Where(it => it.Name == "Плата").FirstOrDefault()?.Id, Name="Компоновка чипов памяти" },
                new Feature { Id=287, FeatureGroupId= featureGroups.Where(it => it.Name == "Подключение").FirstOrDefault()?.Id, Name="Ключ M.2 разъема" },
                new Feature { Id=288, FeatureGroupId= featureGroups.Where(it => it.Name == "Подключение").FirstOrDefault()?.Id, Name="Логический интерфейс" },
                new Feature { Id=289, FeatureGroupId= featureGroups.Where(it => it.Name == "Подключение").FirstOrDefault()?.Id, Name="Адаптер PCI-E - M.2 в комплекте" },
                new Feature { Id=290, FeatureGroupId= featureGroups.Where(it => it.Name == "Показатели скорости").FirstOrDefault()?.Id, Name="Максимальная скорость последовательного чтения" },
                new Feature { Id=291, FeatureGroupId= featureGroups.Where(it => it.Name == "Показатели скорости").FirstOrDefault()?.Id, Name="Максимальная скорость последовательной записи" },
                new Feature { Id=293, FeatureGroupId= featureGroups.Where(it => it.Name == "Показатели скорости").FirstOrDefault()?.Id, Name="Чтение случайных блоков 4 Кбайт" },
                new Feature { Id=294, FeatureGroupId= featureGroups.Where(it => it.Name == "Показатели скорости").FirstOrDefault()?.Id, Name="Запись случайных блоков 4 Кбайт" },
                new Feature { Id=295, FeatureGroupId= featureGroups.Where(it => it.Name == "Показатели скорости").FirstOrDefault()?.Id, Name="Пропускная способность интерфейса" },
                new Feature { Id=296, FeatureGroupId= featureGroups.Where(it => it.Name == "Надежность").FirstOrDefault()?.Id, Name="MTBF (Среднее время между отказами)" },
                new Feature { Id=297, FeatureGroupId= featureGroups.Where(it => it.Name == "Дополнительно").FirstOrDefault()?.Id, Name="Поддержка команды TRIM" },

                new Feature { Id=298, FeatureGroupId= featureGroups.Where(it => it.Name == "Накопитель").FirstOrDefault()?.Id, Name="Объем HDD" },
                new Feature { Id=299, FeatureGroupId= featureGroups.Where(it => it.Name == "Накопитель").FirstOrDefault()?.Id, Name="Гибридный SSHD накопитель (объем SSD буфера)" },
                new Feature { Id=300, FeatureGroupId= featureGroups.Where(it => it.Name == "Накопитель").FirstOrDefault()?.Id, Name="Объем кэш-памяти" },
                new Feature { Id=301, FeatureGroupId= featureGroups.Where(it => it.Name == "Накопитель").FirstOrDefault()?.Id, Name="Скорость вращения шпинделя " },
                new Feature { Id=302, FeatureGroupId= featureGroups.Where(it => it.Name == "Быстродействие").FirstOrDefault()?.Id, Name="Максимальная скорость передачи данных" },
                new Feature { Id=303, FeatureGroupId= featureGroups.Where(it => it.Name == "Быстродействие").FirstOrDefault()?.Id, Name="Среднее время доступа, чтение" },
                new Feature { Id=304, FeatureGroupId= featureGroups.Where(it => it.Name == "Быстродействие").FirstOrDefault()?.Id, Name="Среднее время доступа, запись" },
                new Feature { Id=305, FeatureGroupId= featureGroups.Where(it => it.Name == "Быстродействие").FirstOrDefault()?.Id, Name="Среднее время задержки (Latency)" },
                new Feature { Id=306, FeatureGroupId= featureGroups.Where(it => it.Name == "Быстродействие").FirstOrDefault()?.Id, Name="Поддержка NCQ" },
                new Feature { Id=307, FeatureGroupId= featureGroups.Where(it => it.Name == "Интерфейс").FirstOrDefault()?.Id, Name="Интерфейс" },
                new Feature { Id=308, FeatureGroupId= featureGroups.Where(it => it.Name == "Интерфейс").FirstOrDefault()?.Id, Name="Пропускная способность интерфейса" },
                new Feature { Id=309, FeatureGroupId= featureGroups.Where(it => it.Name == "Интерфейс").FirstOrDefault()?.Id, Name="Оптимизация под RAID-массивы" },
                new Feature { Id=310, FeatureGroupId= featureGroups.Where(it => it.Name == "Механика и надежность").FirstOrDefault()?.Id, Name="Ударостойкость при работе" },
                new Feature { Id=311, FeatureGroupId= featureGroups.Where(it => it.Name == "Механика и надежность").FirstOrDefault()?.Id, Name="Уровень шума во время работы" },
                new Feature { Id=312, FeatureGroupId= featureGroups.Where(it => it.Name == "Механика и надежность").FirstOrDefault()?.Id, Name="Уровень шума в простое" },
                new Feature { Id=313, FeatureGroupId= featureGroups.Where(it => it.Name == "Механика и надежность").FirstOrDefault()?.Id, Name="С гелиевым наполнением" },
                new Feature { Id=314, FeatureGroupId= featureGroups.Where(it => it.Name == "Дополнительно").FirstOrDefault()?.Id, Name="Назначение" },

                new Feature { Id=315, FeatureGroupId= featureGroups.Where(it => it.Name == "Подключение").FirstOrDefault()?.Id, Name="Размещение" },
                new Feature { Id=316, FeatureGroupId= featureGroups.Where(it => it.Name == "Классификация привода").FirstOrDefault()?.Id, Name="Вид привода" },
                new Feature { Id=317, FeatureGroupId= featureGroups.Where(it => it.Name == "Классификация привода").FirstOrDefault()?.Id, Name="Запись на двухслойные диски Blu-ray" },
                new Feature { Id=318, FeatureGroupId= featureGroups.Where(it => it.Name == "Классификация привода").FirstOrDefault()?.Id, Name="Назначение" },
                new Feature { Id=320, FeatureGroupId= featureGroups.Where(it => it.Name == "Скорость чтения").FirstOrDefault()?.Id, Name="Максимальная скорость чтения CD" },
                new Feature { Id=321, FeatureGroupId= featureGroups.Where(it => it.Name == "Скорость чтения").FirstOrDefault()?.Id, Name="Максимальная скорость чтения DVD" },
                new Feature { Id=322, FeatureGroupId= featureGroups.Where(it => it.Name == "Скорость чтения").FirstOrDefault()?.Id, Name="Время доступа в режиме чтения CD" },
                new Feature { Id=323, FeatureGroupId= featureGroups.Where(it => it.Name == "Скорость чтения").FirstOrDefault()?.Id, Name="Время доступа в режиме чтения DVD" },
                new Feature { Id=324, FeatureGroupId= featureGroups.Where(it => it.Name == "Дополнительная информация").FirstOrDefault()?.Id, Name="Объем буфера" },
                new Feature { Id=325, FeatureGroupId= featureGroups.Where(it => it.Name == "Дополнительная информация").FirstOrDefault()?.Id, Name="Поддерживаемые ОС" },
                new Feature { Id=326, FeatureGroupId= featureGroups.Where(it => it.Name == "Дополнительная информация").FirstOrDefault()?.Id, Name="Маркировка дисков" },
                new Feature { Id=327, FeatureGroupId= featureGroups.Where(it => it.Name == "Дополнительная информация").FirstOrDefault()?.Id, Name="Технология маркировки" },

                new Feature { Id=328, FeatureGroupId= featureGroups.Where(it => it.Name == "Классификация").FirstOrDefault()?.Id, Name="Формат звуковой карты" },
                new Feature { Id=329, FeatureGroupId= featureGroups.Where(it => it.Name == "Стандарты").FirstOrDefault()?.Id, Name="Поддержка ASIO" },
                new Feature { Id=330, FeatureGroupId= featureGroups.Where(it => it.Name == "Стандарты").FirstOrDefault()?.Id, Name="Поддержка EAX" },
                new Feature { Id=331, FeatureGroupId= featureGroups.Where(it => it.Name == "Стандарты").FirstOrDefault()?.Id, Name="Другие стандарты" },
                new Feature { Id=332, FeatureGroupId= featureGroups.Where(it => it.Name == "Чипсет").FirstOrDefault()?.Id, Name="Модель чипсета" },
                new Feature { Id=333, FeatureGroupId= featureGroups.Where(it => it.Name == "Воспроизведение").FirstOrDefault()?.Id, Name="Количество каналов воспроизведения" },
                new Feature { Id=334, FeatureGroupId= featureGroups.Where(it => it.Name == "Воспроизведение").FirstOrDefault()?.Id, Name="Модели ЦАП" },
                new Feature { Id=335, FeatureGroupId= featureGroups.Where(it => it.Name == "Воспроизведение").FirstOrDefault()?.Id, Name="Разрядность ЦАП" },
                new Feature { Id=336, FeatureGroupId= featureGroups.Where(it => it.Name == "Воспроизведение").FirstOrDefault()?.Id, Name="Максимальная частота ЦАП" },
                new Feature { Id=337, FeatureGroupId= featureGroups.Where(it => it.Name == "Запись").FirstOrDefault()?.Id, Name="Количество каналов аудиозаписи" },
                new Feature { Id=338, FeatureGroupId= featureGroups.Where(it => it.Name == "Запись").FirstOrDefault()?.Id, Name="Фантомное питание микрофона" },
                new Feature { Id=339, FeatureGroupId= featureGroups.Where(it => it.Name == "Запись").FirstOrDefault()?.Id, Name="Модель АЦП" },
                new Feature { Id=340, FeatureGroupId= featureGroups.Where(it => it.Name == "Разъемы и интерфейсы").FirstOrDefault()?.Id, Name="Внешний блок / передняя панель" },
                new Feature { Id=341, FeatureGroupId= featureGroups.Where(it => it.Name == "Разъемы и интерфейсы").FirstOrDefault()?.Id, Name="Аналоговые выходы (небалансные)" },
                new Feature { Id=342, FeatureGroupId= featureGroups.Where(it => it.Name == "Разъемы и интерфейсы").FirstOrDefault()?.Id, Name="Аналоговые входы (небалансные)" },
                new Feature { Id=343, FeatureGroupId= featureGroups.Where(it => it.Name == "Разъемы и интерфейсы").FirstOrDefault()?.Id, Name="Аналоговые выходы (балансные)" },
                new Feature { Id=344, FeatureGroupId= featureGroups.Where(it => it.Name == "Разъемы и интерфейсы").FirstOrDefault()?.Id, Name="Аналоговые входы (балансные)" },
                new Feature { Id=345, FeatureGroupId= featureGroups.Where(it => it.Name == "Разъемы и интерфейсы").FirstOrDefault()?.Id, Name="Цифровые выходы" },
                new Feature { Id=346, FeatureGroupId= featureGroups.Where(it => it.Name == "Разъемы и интерфейсы").FirstOrDefault()?.Id, Name="Цифровые входы" },
                new Feature { Id=347, FeatureGroupId= featureGroups.Where(it => it.Name == "Разъемы и интерфейсы").FirstOrDefault()?.Id, Name="Интерфейс HDMI" },
                new Feature { Id=348, FeatureGroupId= featureGroups.Where(it => it.Name == "Разъемы и интерфейсы").FirstOrDefault()?.Id, Name="Количество микрофонных входов" },
                new Feature { Id=349, FeatureGroupId= featureGroups.Where(it => it.Name == "Разъемы и интерфейсы").FirstOrDefault()?.Id, Name="Количество независимых выходов на наушники" },
                new Feature { Id=350, FeatureGroupId= featureGroups.Where(it => it.Name == "Разъемы и интерфейсы").FirstOrDefault()?.Id, Name="Инструментальный вход (Hi-Z)" },

                new Feature { Id=351, FeatureGroupId= featureGroups.Where(it => it.Name == "Характеристики видео").FirstOrDefault()?.Id, Name="Поддержка FHD" },
                new Feature { Id=352, FeatureGroupId= featureGroups.Where(it => it.Name == "Характеристики видео").FirstOrDefault()?.Id, Name="Поддержка видеорежимов" },
                new Feature { Id=353, FeatureGroupId= featureGroups.Where(it => it.Name == "Характеристики видео").FirstOrDefault()?.Id, Name="Максимальное разрешение" },
                new Feature { Id=354, FeatureGroupId= featureGroups.Where(it => it.Name == "Характеристики видео").FirstOrDefault()?.Id, Name="Частота кадров на максимальном разрешении" },
                new Feature { Id=355, FeatureGroupId= featureGroups.Where(it => it.Name == "Входы и выходы").FirstOrDefault()?.Id, Name="Разъемы" },
                new Feature { Id=356, FeatureGroupId= featureGroups.Where(it => it.Name == "Входы и выходы").FirstOrDefault()?.Id, Name="FireWire" },
                new Feature { Id=357, FeatureGroupId= featureGroups.Where(it => it.Name == "Дополнительная информация").FirstOrDefault()?.Id, Name="Совместимость" },

                new Feature { Id=358, Name="Цена" },
                new Feature { Id=359, Name="Фото" },

                new Feature { Id=360, FeatureGroupId= featureGroups.Where(it => it.Name == "Частота и возможность разгона").FirstOrDefault()?.Id, Name="Максимальная частота в турбо режиме"}
            };

            modelBuilder.Entity<Feature>().HasData(features);

            modelBuilder.Entity<CPU>().HasData(new CPU[]
            {
                new CPU() { Id = 1 },
                new CPU() { Id = 2 },
                new CPU() { Id = 3 },
                new CPU() { Id = 4 },
                new CPU() { Id = 5 }
            });

            modelBuilder.Entity<CaptureBoard>().HasData(new CaptureBoard[]
            {
                new CaptureBoard() { Id = 6 },
                new CaptureBoard() { Id = 7 },
                new CaptureBoard() { Id = 8 },
                new CaptureBoard() { Id = 9 },
                new CaptureBoard() { Id = 10 }
            });

            modelBuilder.Entity<Case>().HasData(new Case[]
            {
                new Case() { Id = 11 },
                new Case() { Id = 12 },
                new Case() { Id = 13 },
                new Case() { Id = 14 },
                new Case() { Id = 15 },
            });

            /*modelBuilder.Entity<Cooler>().HasData(new Cooler[]
            {
                new Cooler() { Id = 16 },
                new Cooler() { Id = 17 },
                new Cooler() { Id = 18 },
                new Cooler() { Id = 19 },
                new Cooler() { Id = 20 },
            });

            modelBuilder.Entity<Fan>().HasData(new Fan[]
            {
                new Fan() { Id = 21 },
                new Fan() { Id = 22 },
                new Fan() { Id = 23 },
                new Fan() { Id = 24 },
                new Fan() { Id = 25 },
            });*/

            modelBuilder.Entity<GraphicsCard>().HasData(new GraphicsCard[]
            {
                new GraphicsCard() { Id = 26 },
                new GraphicsCard() { Id = 27 },
                new GraphicsCard() { Id = 28 },
                new GraphicsCard() { Id = 29 },
                new GraphicsCard() { Id = 30 },
            });

            modelBuilder.Entity<HDD>().HasData(new HDD[]
            {
                new HDD() { Id = 31 },
                new HDD() { Id = 32 },
                new HDD() { Id = 33 },
                new HDD() { Id = 34 },
                new HDD() { Id = 35 },
            });



            /*modelBuilder.Entity<Liquid>().HasData(new Liquid[]
            {
                new Liquid() { Id = 36 },
                new Liquid() { Id = 37 },
                new Liquid() { Id = 38 },
                new Liquid() { Id = 39 },
                new Liquid() { Id = 40 },
            });*/

            modelBuilder.Entity<Motherboard>().HasData(new Motherboard[]
            {
                new Motherboard() { Id = 41 },
                new Motherboard() { Id = 42 },
                new Motherboard() { Id = 43 },
                new Motherboard() { Id = 44 },
                new Motherboard() { Id = 45 },
            });

            modelBuilder.Entity<OpticalDrive>().HasData(new OpticalDrive[]
            {
                new OpticalDrive() { Id = 46 },
                new OpticalDrive() { Id = 47 },
                new OpticalDrive() { Id = 48 },
                new OpticalDrive() { Id = 49 },
                new OpticalDrive() { Id = 50 },
            });

            modelBuilder.Entity<PowerSupply>().HasData(new PowerSupply[]
            {
                new PowerSupply() { Id = 51 },
                new PowerSupply() { Id = 52 },
                new PowerSupply() { Id = 53 },
                new PowerSupply() { Id = 54 },
                new PowerSupply() { Id = 55 },
            });

            modelBuilder.Entity<RAM>().HasData(new RAM[]
            {
                new RAM() { Id = 56 },
                new RAM() { Id = 57 },
                new RAM() { Id = 58 },
                new RAM() { Id = 59 },
                new RAM() { Id = 60 },
            });

            modelBuilder.Entity<SoundCard>().HasData(new SoundCard[]
            {
                new SoundCard() { Id = 61 },
                new SoundCard() { Id = 62 },
                new SoundCard() { Id = 63 },
                new SoundCard() { Id = 64 },
                new SoundCard() { Id = 65 },
            });

            /*modelBuilder.Entity<SsdM2>().HasData(new SsdM2[]
            {
                new SsdM2() { Id = 66 },
                new SsdM2() { Id = 67 },
                new SsdM2() { Id = 68 },
                new SsdM2() { Id = 69 },
                new SsdM2() { Id = 70 },
            });

            modelBuilder.Entity<SsdSata>().HasData(new SsdSata[]
            {
                new SsdSata() { Id = 71 },
                new SsdSata() { Id = 72 },
                new SsdSata() { Id = 73 },
                new SsdSata() { Id = 74 },
                new SsdSata() { Id = 75 },
            });*/

            

            int num = 1;
            modelBuilder.Entity<Belong>().HasData(
            new Belong[]
            {
                new Belong {Id = num++, AccessoryId = 1, FeatureId = features.Where(it => it.Name == "Цена").FirstOrDefault()?.Id, Value = "1599", Dimension = "руб." },
                new Belong {Id = num++, AccessoryId = 1, FeatureId = features.Where(it => it.Name == "Фото").FirstOrDefault()?.Id, Value = "https://c.dns-shop.ru/thumb/st4/fit/320/250/5d6bdec582ed85475a02b9c500284292/3b46ddd7bdd78f9840b9d6caa966c7182766bbba92604afa43673faef33689bd.jpg", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 1, FeatureId = features.Where(it => it.Name == "Гарантия").FirstOrDefault()?.Id, Value = "12", Dimension = "мес" },
                new Belong {Id = num++, AccessoryId = 1, FeatureId =  features.Where(it => it.Name == "Страна производитель").FirstOrDefault()?.Id, Value = "Малайзия", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 1, FeatureId = features.Where(it => it.Name == "Модель").FirstOrDefault()?.Id, Value = "AMD Athlon X4 840", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 1, FeatureId = features.Where(it => it.Name == "Код производителя").FirstOrDefault()?.Id, Value = "[AD840XYBI44JA]", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 1, FeatureId = features.Where(it => it.Name == "Год релиза").FirstOrDefault()?.Id, Value = "2014", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 1, FeatureId = features.Where(it => it.Name == "Сокет").FirstOrDefault()?.Id, Value = "FM2+", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 1, FeatureId = features.Where(it => it.Name == "Система охлаждения в комплекте").FirstOrDefault()?.Id, Value = "нет", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 1, FeatureId = features.Where(it => it.Name == "Ядро").FirstOrDefault()?.Id, Value = "Kaveri", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 1, FeatureId = features.Where(it => it.Name == "Техпроцесс").FirstOrDefault()?.Id, Value = "28", Dimension = "нм" },
                new Belong {Id = num++, AccessoryId = 1, FeatureId = features.Where(it => it.Name == "Количество ядер").FirstOrDefault()?.Id, Value = "4", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 1, FeatureId = features.Where(it => it.Name == "Максимальное число потоков").FirstOrDefault()?.Id, Value = "4", Dimension = "шт." },
                new Belong {Id = num++, AccessoryId = 1, FeatureId = features.Where(it => it.Name == "Кэш L1 (инструкции)").FirstOrDefault()?.Id, Value = "192", Dimension = "КБ" },
                new Belong {Id = num++, AccessoryId = 1, FeatureId = features.Where(it => it.Name == "Кэш L1 (данные)").FirstOrDefault()?.Id, Value = "64", Dimension = "КБ" },
                new Belong {Id = num++, AccessoryId = 1, FeatureId = features.Where(it => it.Name == "Объем кэша L2").FirstOrDefault()?.Id, Value = "4", Dimension = "КБ" },
                new Belong {Id = num++, AccessoryId = 1, FeatureId = features.Where(it => it.Name == "Объем кэша L3").FirstOrDefault()?.Id, Value = "нет", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 1, FeatureId = features.Where(it => it.Name == "Базовая частота процессора").FirstOrDefault()?.Id, Value = "3100", Dimension = "МГц" },
                new Belong {Id = num++, AccessoryId = 1, FeatureId = features.Where(it => it.Name == "Максимальная частота в турбо режиме").FirstOrDefault()?.Id, Value = "3800", Dimension = "МГц" },
                new Belong {Id = num++, AccessoryId = 1, FeatureId = features.Where(it => it.Name == "Множитель").FirstOrDefault()?.Id, Value = "31", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 1, FeatureId = features.Where(it => it.Name == "Свободный множитель").FirstOrDefault()?.Id, Value = "нет", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 1, FeatureId = features.Where(it => it.Name == "Тип памяти").FirstOrDefault()?.Id, Value = "DD3", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 1, FeatureId = features.Where(it => it.Name == "Максимально поддерживаемый объем памяти").FirstOrDefault()?.Id, Value = "64", Dimension = "ГБ" },
                new Belong {Id = num++, AccessoryId = 1, FeatureId = features.Where(it => it.Name == "Количество каналов").FirstOrDefault()?.Id, Value = "2", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 1, FeatureId = features.Where(it => it.Name == "Минимальная частота оперативной памяти").FirstOrDefault()?.Id, Value = "800", Dimension = "МГц" },
                new Belong {Id = num++, AccessoryId = 1, FeatureId = features.Where(it => it.Name == "Максимальная частота оперативной памяти").FirstOrDefault()?.Id, Value = "2133", Dimension = "МГц" },
                new Belong {Id = num++, AccessoryId = 1, FeatureId = features.Where(it => it.Name == "Поддержка режима ECC").FirstOrDefault()?.Id, Value = "нет", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 1, FeatureId = features.Where(it => it.Name == "Тепловыделение (TDP)").FirstOrDefault()?.Id, Value = "65", Dimension = "Вт" },
                new Belong {Id = num++, AccessoryId = 1, FeatureId = features.Where(it => it.Name == "Максимальная температура процессора").FirstOrDefault()?.Id, Value = "71", Dimension = "°C" },
                new Belong {Id = num++, AccessoryId = 1, FeatureId = features.Where(it => it.Name == "Интегрированное графическое ядро").FirstOrDefault()?.Id, Value = "нет", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 1, FeatureId = features.Where(it => it.Name == "Модель графического процессора").FirstOrDefault()?.Id, Value = "нет", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 1, FeatureId = features.Where(it => it.Name == "Системная шина").FirstOrDefault()?.Id, Value = "QPI", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 1, FeatureId = features.Where(it => it.Name == "Пропускная способность шины").FirstOrDefault()?.Id, Value = "5 GT/s", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 1, FeatureId = features.Where(it => it.Name == "Встроенный контроллер PCI Express").FirstOrDefault()?.Id, Value = "PCI-E 3.0", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 1, FeatureId = features.Where(it => it.Name == "Число линий PCI Express").FirstOrDefault()?.Id, Value = "16", Dimension = "шт." },
                new Belong {Id = num++, AccessoryId = 1, FeatureId = features.Where(it => it.Name == "Поддержка 64-битного набора команд").FirstOrDefault()?.Id, Value = "AMD64", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 1, FeatureId = features.Where(it => it.Name == "Многопоточность").FirstOrDefault()?.Id, Value = "нет", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 1, FeatureId = features.Where(it => it.Name == "Технология виртуализации").FirstOrDefault()?.Id, Value = "есть", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 1, FeatureId = features.Where(it => it.Name == "Технология повышения частоты процессора").FirstOrDefault()?.Id, Value = "Turbo Core 3.0", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 1, FeatureId = features.Where(it => it.Name == "Технология энергосбережения").FirstOrDefault()?.Id, Value = "PowerNow!", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 1, FeatureId = features.Where(it => it.Name == "Набор инструкций и команд").FirstOrDefault()?.Id, Value = "SSE4a, EVP, XOP, TBM, FMA4, SSE, SSE2, MMX, SSE3, SSSE3, SSE4, SSE4.1, SSE4.2, AES, AVX, BMI1, F16C, FMA3", Dimension = "" },

                new Belong {Id = num++, AccessoryId = 2, FeatureId = features.Where(it => it.Name == "Цена").FirstOrDefault()?.Id, Value = "4299", Dimension = "руб." },
                new Belong {Id = num++, AccessoryId = 2, FeatureId = features.Where(it => it.Name == "Фото").FirstOrDefault()?.Id, Value = "https://c.dns-shop.ru/thumb/st4/fit/320/250/8ea5fbe56b7688d956585bd62a81905f/5fb50df1151984901e2e2aeaecc40227658a191bcf4a9158ce2816f5ed7e1b4d.jpg", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 2, FeatureId = features.Where(it => it.Name == "Гарантия").FirstOrDefault()?.Id, Value = "36", Dimension = "мес" },
                new Belong {Id = num++, AccessoryId = 2, FeatureId =  features.Where(it => it.Name == "Страна производитель").FirstOrDefault()?.Id, Value = "Вьетнам", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 2, FeatureId = features.Where(it => it.Name == "Модель").FirstOrDefault()?.Id, Value = "Intel Celeron G5925", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 2, FeatureId = features.Where(it => it.Name == "Код производителя").FirstOrDefault()?.Id, Value = "[BX80701G5925]", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 2, FeatureId = features.Where(it => it.Name == "Год релиза").FirstOrDefault()?.Id, Value = "2020", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 2, FeatureId = features.Where(it => it.Name == "Сокет").FirstOrDefault()?.Id, Value = "LGA 1200", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 2, FeatureId = features.Where(it => it.Name == "Система охлаждения в комплекте").FirstOrDefault()?.Id, Value = "есть", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 2, FeatureId = features.Where(it => it.Name == "Ядро").FirstOrDefault()?.Id, Value = "Comet Lake-S", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 2, FeatureId = features.Where(it => it.Name == "Техпроцесс").FirstOrDefault()?.Id, Value = "14", Dimension = "нм" },
                new Belong {Id = num++, AccessoryId = 2, FeatureId = features.Where(it => it.Name == "Количество ядер").FirstOrDefault()?.Id, Value = "2", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 2, FeatureId = features.Where(it => it.Name == "Максимальное число потоков").FirstOrDefault()?.Id, Value = "2", Dimension = "шт." },
                new Belong {Id = num++, AccessoryId = 2, FeatureId = features.Where(it => it.Name == "Кэш L1 (инструкции)").FirstOrDefault()?.Id, Value = "64", Dimension = "КБ" },
                new Belong {Id = num++, AccessoryId = 2, FeatureId = features.Where(it => it.Name == "Кэш L1 (данные)").FirstOrDefault()?.Id, Value = "64", Dimension = "КБ" },
                new Belong {Id = num++, AccessoryId = 2, FeatureId = features.Where(it => it.Name == "Объем кэша L2").FirstOrDefault()?.Id, Value = "512", Dimension = "КБ" },
                new Belong {Id = num++, AccessoryId = 2, FeatureId = features.Where(it => it.Name == "Объем кэша L3").FirstOrDefault()?.Id, Value = "4", Dimension = "МБ" },
                new Belong {Id = num++, AccessoryId = 2, FeatureId = features.Where(it => it.Name == "Базовая частота процессора").FirstOrDefault()?.Id, Value = "3600", Dimension = "МГц" },
                new Belong {Id = num++, AccessoryId = 2, FeatureId = features.Where(it => it.Name == "Максимальная частота в турбо режиме").FirstOrDefault()?.Id, Value = "нет", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 2, FeatureId = features.Where(it => it.Name == "Множитель").FirstOrDefault()?.Id, Value = "36", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 2, FeatureId = features.Where(it => it.Name == "Свободный множитель").FirstOrDefault()?.Id, Value = "нет", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 2, FeatureId = features.Where(it => it.Name == "Тип памяти").FirstOrDefault()?.Id, Value = "DD4", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 2, FeatureId = features.Where(it => it.Name == "Максимально поддерживаемый объем памяти").FirstOrDefault()?.Id, Value = "128", Dimension = "ГБ" },
                new Belong {Id = num++, AccessoryId = 2, FeatureId = features.Where(it => it.Name == "Количество каналов").FirstOrDefault()?.Id, Value = "2", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 2, FeatureId = features.Where(it => it.Name == "Минимальная частота оперативной памяти").FirstOrDefault()?.Id, Value = "1600", Dimension = "МГц" },
                new Belong {Id = num++, AccessoryId = 2, FeatureId = features.Where(it => it.Name == "Максимальная частота оперативной памяти").FirstOrDefault()?.Id, Value = "2666", Dimension = "МГц" },
                new Belong {Id = num++, AccessoryId = 2, FeatureId = features.Where(it => it.Name == "Поддержка режима ECC").FirstOrDefault()?.Id, Value = "нет", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 2, FeatureId = features.Where(it => it.Name == "Тепловыделение (TDP)").FirstOrDefault()?.Id, Value = "58", Dimension = "Вт" },
                new Belong {Id = num++, AccessoryId = 2, FeatureId = features.Where(it => it.Name == "Максимальная температура процессора").FirstOrDefault()?.Id, Value = "100", Dimension = "°C" },
                new Belong {Id = num++, AccessoryId = 2, FeatureId = features.Where(it => it.Name == "Интегрированное графическое ядро").FirstOrDefault()?.Id, Value = "есть", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 2, FeatureId = features.Where(it => it.Name == "Модель графического процессора").FirstOrDefault()?.Id, Value = "Intel UHD Graphics 610", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 2, FeatureId = features.Where(it => it.Name == "Системная шина").FirstOrDefault()?.Id, Value = "DMI 3.0", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 2, FeatureId = features.Where(it => it.Name == "Пропускная способность шины").FirstOrDefault()?.Id, Value = "8 GT/s", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 2, FeatureId = features.Where(it => it.Name == "Встроенный контроллер PCI Express").FirstOrDefault()?.Id, Value = "PCI-E 3.0", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 2, FeatureId = features.Where(it => it.Name == "Число линий PCI Express").FirstOrDefault()?.Id, Value = "16", Dimension = "шт." },
                new Belong {Id = num++, AccessoryId = 2, FeatureId = features.Where(it => it.Name == "Поддержка 64-битного набора команд").FirstOrDefault()?.Id, Value = "EM64T", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 2, FeatureId = features.Where(it => it.Name == "Многопоточность").FirstOrDefault()?.Id, Value = "нет", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 2, FeatureId = features.Where(it => it.Name == "Технология виртуализации").FirstOrDefault()?.Id, Value = "есть", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 2, FeatureId = features.Where(it => it.Name == "Технология повышения частоты процессора").FirstOrDefault()?.Id, Value = "нет", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 2, FeatureId = features.Where(it => it.Name == "Технология энергосбережения").FirstOrDefault()?.Id, Value = "Enhanced SpeedStep", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 2, FeatureId = features.Where(it => it.Name == "Набор инструкций и команд").FirstOrDefault()?.Id, Value = "EPT, VT-x, VT-d, SGX, SIPP, SSE4.1, EDB, AES, SSE4.2", Dimension = "" },

                new Belong {Id = num++, AccessoryId = 3, FeatureId = features.Where(it => it.Name == "Цена").FirstOrDefault()?.Id, Value = "8199", Dimension = "руб." },
                new Belong {Id = num++, AccessoryId = 3, FeatureId = features.Where(it => it.Name == "Фото").FirstOrDefault()?.Id, Value = "https://c.dns-shop.ru/thumb/st4/fit/320/250/120d4d6fad84b41aae2ebcd93a3746a2/784cc4980a12f477bfedf2ea75ac4cdc8fbd299f856aeb32f134a3d264882a1d.jpg", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 3, FeatureId = features.Where(it => it.Name == "Гарантия").FirstOrDefault()?.Id, Value = "12", Dimension = "мес" },
                new Belong {Id = num++, AccessoryId = 3, FeatureId =  features.Where(it => it.Name == "Страна производитель").FirstOrDefault()?.Id, Value = "Малайзия", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 3, FeatureId = features.Where(it => it.Name == "Модель").FirstOrDefault()?.Id, Value = "AMD Ryzen 3 3100", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 3, FeatureId = features.Where(it => it.Name == "Код производителя").FirstOrDefault()?.Id, Value = "[100-100000284]", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 3, FeatureId = features.Where(it => it.Name == "Год релиза").FirstOrDefault()?.Id, Value = "2020", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 3, FeatureId = features.Where(it => it.Name == "Сокет").FirstOrDefault()?.Id, Value = "AM4", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 3, FeatureId = features.Where(it => it.Name == "Система охлаждения в комплекте").FirstOrDefault()?.Id, Value = "нет", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 3, FeatureId = features.Where(it => it.Name == "Ядро").FirstOrDefault()?.Id, Value = "Matisse", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 3, FeatureId = features.Where(it => it.Name == "Техпроцесс").FirstOrDefault()?.Id, Value = "7", Dimension = "нм" },
                new Belong {Id = num++, AccessoryId = 3, FeatureId = features.Where(it => it.Name == "Количество ядер").FirstOrDefault()?.Id, Value = "4", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 3, FeatureId = features.Where(it => it.Name == "Максимальное число потоков").FirstOrDefault()?.Id, Value = "8", Dimension = "шт." },
                new Belong {Id = num++, AccessoryId = 3, FeatureId = features.Where(it => it.Name == "Кэш L1 (инструкции)").FirstOrDefault()?.Id, Value = "128", Dimension = "КБ" },
                new Belong {Id = num++, AccessoryId = 3, FeatureId = features.Where(it => it.Name == "Кэш L1 (данные)").FirstOrDefault()?.Id, Value = "128", Dimension = "КБ" },
                new Belong {Id = num++, AccessoryId = 3, FeatureId = features.Where(it => it.Name == "Объем кэша L2").FirstOrDefault()?.Id, Value = "2", Dimension = "МБ" },
                new Belong {Id = num++, AccessoryId = 3, FeatureId = features.Where(it => it.Name == "Объем кэша L3").FirstOrDefault()?.Id, Value = "16", Dimension = "МБ" },
                new Belong {Id = num++, AccessoryId = 3, FeatureId = features.Where(it => it.Name == "Базовая частота процессора").FirstOrDefault()?.Id, Value = "3600", Dimension = "МГц" },
                new Belong {Id = num++, AccessoryId = 3, FeatureId = features.Where(it => it.Name == "Максимальная частота в турбо режиме").FirstOrDefault()?.Id, Value = "3900", Dimension = "МГц" },
                new Belong {Id = num++, AccessoryId = 3, FeatureId = features.Where(it => it.Name == "Множитель").FirstOrDefault()?.Id, Value = "36", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 3, FeatureId = features.Where(it => it.Name == "Свободный множитель").FirstOrDefault()?.Id, Value = "есть", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 3, FeatureId = features.Where(it => it.Name == "Тип памяти").FirstOrDefault()?.Id, Value = "DD4", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 3, FeatureId = features.Where(it => it.Name == "Максимально поддерживаемый объем памяти").FirstOrDefault()?.Id, Value = "64", Dimension = "ГБ" },
                new Belong {Id = num++, AccessoryId = 3, FeatureId = features.Where(it => it.Name == "Количество каналов").FirstOrDefault()?.Id, Value = "2", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 3, FeatureId = features.Where(it => it.Name == "Минимальная частота оперативной памяти").FirstOrDefault()?.Id, Value = "1600", Dimension = "МГц" },
                new Belong {Id = num++, AccessoryId = 3, FeatureId = features.Where(it => it.Name == "Максимальная частота оперативной памяти").FirstOrDefault()?.Id, Value = "3200", Dimension = "МГц" },
                new Belong {Id = num++, AccessoryId = 3, FeatureId = features.Where(it => it.Name == "Поддержка режима ECC").FirstOrDefault()?.Id, Value = "есть", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 3, FeatureId = features.Where(it => it.Name == "Тепловыделение (TDP)").FirstOrDefault()?.Id, Value = "65", Dimension = "Вт" },
                new Belong {Id = num++, AccessoryId = 3, FeatureId = features.Where(it => it.Name == "Интегрированное графическое ядро").FirstOrDefault()?.Id, Value = "нет", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 3, FeatureId = features.Where(it => it.Name == "Модель графического процессора").FirstOrDefault()?.Id, Value = "нет", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 3, FeatureId = features.Where(it => it.Name == "Встроенный контроллер PCI Express").FirstOrDefault()?.Id, Value = "PCI-E 4.0", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 3, FeatureId = features.Where(it => it.Name == "Число линий PCI Express").FirstOrDefault()?.Id, Value = "24", Dimension = "шт." },
                new Belong {Id = num++, AccessoryId = 3, FeatureId = features.Where(it => it.Name == "Поддержка 64-битного набора команд").FirstOrDefault()?.Id, Value = "AMD64", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 3, FeatureId = features.Where(it => it.Name == "Многопоточность").FirstOrDefault()?.Id, Value = "есть", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 3, FeatureId = features.Where(it => it.Name == "Технология виртуализации").FirstOrDefault()?.Id, Value = "есть", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 3, FeatureId = features.Where(it => it.Name == "Технология повышения частоты процессора").FirstOrDefault()?.Id, Value = "Precision Boost", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 3, FeatureId = features.Where(it => it.Name == "Технология энергосбережения").FirstOrDefault()?.Id, Value = "Pure Power", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 3, FeatureId = features.Where(it => it.Name == "Набор инструкций и команд").FirstOrDefault()?.Id, Value = "AES, AVX, AVX2, FMA3, AMD-V, SSE4a, SSE4.1, SHA, SSE4.2, SSSE3, SSE3, MMX, SSE, SSE2", Dimension = "" },

   /*123*/      new Belong {Id = num++, AccessoryId = 6, FeatureId = features.Where(it => it.Name == "Цена").FirstOrDefault()?.Id, Value = "799", Dimension = "руб." },
                new Belong {Id = num++, AccessoryId = 6, FeatureId = features.Where(it => it.Name == "Фото").FirstOrDefault()?.Id, Value = "https://c.dns-shop.ru/thumb/st1/fit/320/250/f501a386321c507ce462bd53cd80af90/20146326314b9d684f740cea75aeff1ba3101d193b275b08f9450e7b0a2eb5fc.jpg", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 6, FeatureId = features.Where(it => it.Name == "Гарантия").FirstOrDefault()?.Id, Value = "12", Dimension = "мес" },
                new Belong {Id = num++, AccessoryId = 6, FeatureId =  features.Where(it => it.Name == "Страна производитель").FirstOrDefault()?.Id, Value = "Китай", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 6, FeatureId = features.Where(it => it.Name == "Модель").FirstOrDefault()?.Id, Value = "ESPADA EUsbRca63", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 6, FeatureId = features.Where(it => it.Name == "Поддержка FHD").FirstOrDefault()?.Id, Value = "нет", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 6, FeatureId = features.Where(it => it.Name == "Поддержка видеорежимов").FirstOrDefault()?.Id, Value = "720p", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 6, FeatureId = features.Where(it => it.Name == "Максимальное разрешение").FirstOrDefault()?.Id, Value = "720х576", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 6, FeatureId = features.Where(it => it.Name == "Частота кадров на максимальном разрешении").FirstOrDefault()?.Id, Value = "30", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 6, FeatureId = features.Where(it => it.Name == "Разъемы").FirstOrDefault()?.Id, Value = "S-Video, USB 2.0, RCA x 3", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 6, FeatureId = features.Where(it => it.Name == "FireWire").FirstOrDefault()?.Id, Value = "нет", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 6, FeatureId = features.Where(it => it.Name == "Совместимость").FirstOrDefault()?.Id, Value = "Microsoft Windows 7, Microsoft Windows Vista, Microsoft Windows 8, Microsoft Windows XP", Dimension = "" },

                new Belong {Id = num++, AccessoryId = 7, FeatureId = features.Where(it => it.Name == "Цена").FirstOrDefault()?.Id, Value = "8999", Dimension = "руб." },
                new Belong {Id = num++, AccessoryId = 7, FeatureId = features.Where(it => it.Name == "Фото").FirstOrDefault()?.Id, Value = "https://c.dns-shop.ru/thumb/st1/fit/320/250/dc7c88ab00eabe6998b2fed5a6290c4c/f3118f02edfcb8dd39e84a3ae1ead86b3d2fdcc830e5e1c79d3a66e433392459.jpg", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 7, FeatureId = features.Where(it => it.Name == "Гарантия").FirstOrDefault()?.Id, Value = "12", Dimension = "мес" },
                new Belong {Id = num++, AccessoryId = 7, FeatureId =  features.Where(it => it.Name == "Страна производитель").FirstOrDefault()?.Id, Value = "Китай", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 7, FeatureId = features.Where(it => it.Name == "Модель").FirstOrDefault()?.Id, Value = "ESPADA EUsbRca63", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 7, FeatureId = features.Where(it => it.Name == "Поддержка FHD").FirstOrDefault()?.Id, Value = "нет", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 7, FeatureId = features.Where(it => it.Name == "Поддержка видеорежимов").FirstOrDefault()?.Id, Value = "1080p, 1080i, 720p", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 7, FeatureId = features.Where(it => it.Name == "Максимальное разрешение").FirstOrDefault()?.Id, Value = "1920х1080", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 7, FeatureId = features.Where(it => it.Name == "Частота кадров на максимальном разрешении").FirstOrDefault()?.Id, Value = "30", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 7, FeatureId = features.Where(it => it.Name == "Разъемы").FirstOrDefault()?.Id, Value = "mini USB 2.0, mini jack 3.5 mm (наушники), HDMI", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 7, FeatureId = features.Where(it => it.Name == "FireWire").FirstOrDefault()?.Id, Value = "нет", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 7, FeatureId = features.Where(it => it.Name == "Совместимость").FirstOrDefault()?.Id, Value = "Microsoft Windows 10, Mac OS X v10.9 или более поздняя", Dimension = "" },

                new Belong {Id = num++, AccessoryId = 8, FeatureId = features.Where(it => it.Name == "Цена").FirstOrDefault()?.Id, Value = "12999", Dimension = "руб." },
                new Belong {Id = num++, AccessoryId = 8, FeatureId = features.Where(it => it.Name == "Фото").FirstOrDefault()?.Id, Value = "https://c.dns-shop.ru/thumb/st4/fit/320/250/9f8b9987af16798b02ac6f065c63184f/03ec8fee9967e7ccd4f90daf5488831e74df895c851e04a08888fa9e48e0d542.jpg", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 8, FeatureId = features.Where(it => it.Name == "Гарантия").FirstOrDefault()?.Id, Value = "24", Dimension = "мес" },
                new Belong {Id = num++, AccessoryId = 8, FeatureId =  features.Where(it => it.Name == "Страна производитель").FirstOrDefault()?.Id, Value = "Тайвань(Китай)", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 8, FeatureId = features.Where(it => it.Name == "Модель").FirstOrDefault()?.Id, Value = "Elgato Stream Deck", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 8, FeatureId = features.Where(it => it.Name == "Совместимость").FirstOrDefault()?.Id, Value = "Microsoft Windows 10, Mac OS X v10.11 или более поздняя (32/64-Bit)", Dimension = "" },

                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Цена").FirstOrDefault()?.Id, Value = "1199", Dimension = "руб." },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Фото").FirstOrDefault()?.Id, Value = "https://c.dns-shop.ru/thumb/st1/fit/320/250/59a1ace030fe632efe2d59c796d2207b/d5d3b8f60abadbd86cc47b284e352e2b1ffef2232684484648db1345238318ac.jpg", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Гарантия").FirstOrDefault()?.Id, Value = "12", Dimension = "мес" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId =  features.Where(it => it.Name == "Страна производитель").FirstOrDefault()?.Id, Value = "Китай", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Модель").FirstOrDefault()?.Id, Value = "GiNZZU B180", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Код производителя").FirstOrDefault()?.Id, Value = "[17220]", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Год релиза").FirstOrDefault()?.Id, Value = "2019", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Форм-фактор совместимых плат").FirstOrDefault()?.Id, Value = "Micro-ATX", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Типоразмер корпуса").FirstOrDefault()?.Id, Value = "Mini-Tower", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Корпус для HTPC").FirstOrDefault()?.Id, Value = "нет", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Размещение блока питания").FirstOrDefault()?.Id, Value = "нет", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Форм-фактор совместимых блоков питания").FirstOrDefault()?.Id, Value = "ATX", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Док-станция для HDD/SSD").FirstOrDefault()?.Id, Value = "нет", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Материал корпуса").FirstOrDefault()?.Id, Value = "сталь, пластик", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Толщина металла").FirstOrDefault()?.Id, Value = "0.45", Dimension = "мм" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Положение корзин накопителей").FirstOrDefault()?.Id, Value = "вертикально", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Отсеки для 2.5 накопителей").FirstOrDefault()?.Id, Value = "есть", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Количество отсеков 2.5 накопителей").FirstOrDefault()?.Id, Value = "2", Dimension = "шт." },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Число внутренних отсеков 3.5").FirstOrDefault()?.Id, Value = "2", Dimension = "шт." },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Число внешних отсеков 3.5").FirstOrDefault()?.Id, Value = "нет", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Число отсеков 5.25").FirstOrDefault()?.Id, Value = "нет", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Количество слотов расширения").FirstOrDefault()?.Id, Value = "4", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Максимальная длина устанавливаемой видеокарты").FirstOrDefault()?.Id, Value = "250", Dimension = "мм" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Максимальная высота процессорного кулера").FirstOrDefault()?.Id, Value = "140", Dimension = "мм" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Малошумные и антивибрационные корпуса").FirstOrDefault()?.Id, Value = "нет", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Вентиляторы в комплекте").FirstOrDefault()?.Id, Value = "нет", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Поддержка фронтальных вентиляторов").FirstOrDefault()?.Id, Value = "1 x 120", Dimension = "мм" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Поддержка тыловых вентиляторов").FirstOrDefault()?.Id, Value = "1 x 80", Dimension = "мм" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Поддержка верхних вентиляторов").FirstOrDefault()?.Id, Value = "нет", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Поддержка нижних вентиляторов").FirstOrDefault()?.Id, Value = "нет", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Поддержка боковых вентиляторов").FirstOrDefault()?.Id, Value = "1 x 120", Dimension = "мм" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Возможность установки системы жидкостного охлаждения").FirstOrDefault()?.Id, Value = "нет", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Блок управления вентиляторами").FirstOrDefault()?.Id, Value = "нет", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Расположение I/O панели").FirstOrDefault()?.Id, Value = "спереди", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Количество и тип USB портов").FirstOrDefault()?.Id, Value = "2 x USB 2.0", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Аудио разъемы").FirstOrDefault()?.Id, Value = "микрофонный вход (jack 3.5), выход на наушники (jack 3.5)", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Интерфейсы eSATA").FirstOrDefault()?.Id, Value = "нет", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Встроенный кард-ридер").FirstOrDefault()?.Id, Value = "нет", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Безвинтовое крепление в отсеках 3,5").FirstOrDefault()?.Id, Value = "нет", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Безвинтовое крепление в отсеках 5,25").FirstOrDefault()?.Id, Value = "нет", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Безвинтовое крепление в слотах расширения").FirstOrDefault()?.Id, Value = "нет", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Прокладка кабелей за задней стенкой").FirstOrDefault()?.Id, Value = "есть", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Вырез в районе крепления кулера CPU").FirstOrDefault()?.Id, Value = "нет", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Наличие окна на боковой стенке").FirstOrDefault()?.Id, Value = "нет", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Подсветка").FirstOrDefault()?.Id, Value = "нет", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Пылевой фильтр").FirstOrDefault()?.Id, Value = "нет", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Комплектация").FirstOrDefault()?.Id, Value = "набор крепежа, документация", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Возможность закрывать крышку на замок").FirstOrDefault()?.Id, Value = "нет", Dimension = "" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Длина").FirstOrDefault()?.Id, Value = "295", Dimension = "мм" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Ширина").FirstOrDefault()?.Id, Value = "165", Dimension = "мм" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Высота").FirstOrDefault()?.Id, Value = "345", Dimension = "мм" },
                new Belong {Id = num++, AccessoryId = 11, FeatureId = features.Where(it => it.Name == "Вес").FirstOrDefault()?.Id, Value = "1.9", Dimension = "кг" },

            }
            );
            



            base.OnModelCreating(modelBuilder); // использование Fluent API
        }
        
    }
}
