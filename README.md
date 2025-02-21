# Лабораторные работы по паттернам проектирования

Этот репозиторий содержит реализации различных паттернов проектирования, используемых в программировании. Каждая лабораторная работа сопровождается UML-диаграммами и пояснениями.

## 📌 Lab 1: Singleton и Abstract Factory

### 1️⃣ Реализация паттерна Singleton
**Задача:**
- Реализовать паттерн Singleton на C#.
- Гарантировать, что в программе существует только один экземпляр класса.

**Ключевые моменты реализации:**
- Закрытый конструктор.
- Статическое поле для хранения экземпляра.
- Метод `GetInstance()` для получения единственного объекта
📌 **Код Singleton:** [Посмотреть]([https://github.com/Gandoler/PatternsLab/blob/main/Lab1/Singleton.cs](https://github.com/Gandoler/PatternsLab/blob/main/First_Lab/SingletonStaticConstr.cs)
    
### 2️⃣ Реализация Abstract Factory
**Задача:**
- Контролировать загрузку и готовность к отправлению автобусов и такси.
- Учитывать категории водительских прав.
- Учитывать лимиты загрузки (30 чел. для автобуса, 4 чел. для такси).
- Исключить возможность поездки без пассажиров.
![image](https://github.com/user-attachments/assets/102fe977-cf23-4cc1-8d0c-a4ece2c74b3b)
📌 **Код Abstract Factory:** [Посмотреть]([https://github.com/Gandoler/PatternsLab/blob/main/Lab1/AbstractFactory.cs](https://github.com/Gandoler/PatternsLab/tree/main/First_Lab/AFactory)


## 📌 Lab 2: Builder

**Задача:**
- Использовать паттерн Builder для организации посадки пассажиров в автобус и такси.
- Разделить пассажиров автобуса на три категории (взрослый, льготный, ребенок), а пассажиров такси — на две (взрослый, ребенок).
- Учитывать необходимость детского кресла в такси.
![image](https://github.com/user-attachments/assets/9899a18a-425d-4927-93c6-0745438f3818)
📌 **UML-диаграммы:**
- [Диаграмма классов](https://github.com/Gandoler/PatternsLab/blob/main/Second_Lab/Uml/SecondLabUml.png)
- [Диаграмма последовательности](https://github.com/Gandoler/PatternsLab/blob/main/Second_Lab/Uml/Lab2SeqUml.png)

📌 **Код Builder:** [Посмотреть]([https://github.com/Gandoler/PatternsLab/blob/main/Lab2/Builder.cs](https://github.com/Gandoler/PatternsLab/tree/main/Second_Lab)
### Разница между Abstract Factory и Builder
- **Абстрактная фабрика** создаёт семейства объектов, гарантируя их совместимость.
- **Строитель** создаёт сложные объекты пошагово, управляя их конфигурацией.

## 📌 Lab 3: Composite

**Задача:**
- Организовать контроль загрузки самолета с помощью паттерна Composite.
- Разделить пассажиров по классам (Первый, Бизнес, Эконом) с разными лимитами багажа.
- Учесть перегрузку и возможность снятия багажа пассажиров эконом-класса.
![image](https://github.com/user-attachments/assets/6fcb1404-e8ec-4ead-b7b6-4aa692a7c2b0)

![image](https://github.com/user-attachments/assets/28cfb8b8-823a-40f3-9b80-9c2bcafefc40)

📌 **UML-диаграммы:**
- [Диаграмма классов](https://github.com/Gandoler/PatternsLab/blob/main/TH_lab3/Uml/lab3ClassUML.png)
- [Диаграмма последовательности](https://github.com/Gandoler/PatternsLab/blob/main/TH_lab3/Uml/Lab3SeqUml.png)

📌 **Код Composite:** [Посмотреть]([https://github.com/Gandoler/PatternsLab/blob/main/Lab3/Composite.cs](https://github.com/Gandoler/PatternsLab/tree/main/TH_lab3/Units)


### Целесообразность применения Composite
Composite позволяет работать с группами пассажиров как с единым объектом, упрощая контроль загрузки и обработку багажа.

### Родственные паттерны Composite
- **Decorator** – добавляет объектам новые свойства.
- **Flyweight** – уменьшает затраты памяти.
- **Prototype** – позволяет клонировать объекты.
- **Builder** – поэтапно создаёт сложные структуры.


## 📌 Lab 4: Proxy

**Задача:**
- Разработать модель графического редактора.
- Реализовать отображение бокса с размерами изображения.
- Обеспечить перемещение бокса по экрану.
- Реализовать загрузку изображения при двойном клике правой кнопкой мыши.
![image](https://github.com/user-attachments/assets/26a35f91-b787-48c3-b9d9-6efef13874ac)
![image](https://github.com/user-attachments/assets/9b3ae4b4-5084-4757-a515-08e2aefc0164)

📌 **UML-диаграммы:**
- [Диаграмма классов]([https://github.com/Gandoler/PatternsLab/blob/main/Lab4/Uml/Lab4ClassUML.png](https://github.com/Gandoler/PatternsLab478/blob/master/LAB4/Lab4ClassUML.png)
- [Диаграмма последовательности]([https://github.com/Gandoler/PatternsLab/blob/main/Lab4/Uml/Lab4SeqUml.png](https://github.com/Gandoler/PatternsLab478/blob/master/LAB4/Lab4SeqUml.png))

📌 **Код Proxy:** [Посмотреть]([https://github.com/Gandoler/PatternsLab/blob/main/Lab4/Proxy.cs](https://github.com/Gandoler/PatternsLab478/tree/master/LAB4)

---
## 📖 Различия между паттернами

| Паттерн | Описание |
|---------|----------|
| **Singleton** | Гарантирует, что существует только один экземпляр класса. |
| **Abstract Factory** | Позволяет создавать семейства взаимосвязанных объектов без указания конкретных классов. |
| **Builder** | Разделяет процесс создания сложного объекта и его конфигурацию. |
| **Composite** | Позволяет работать с группами объектов как с единым целым. |
| **Proxy** | Контролирует доступ к объекту, позволяя лениво загружать или защищать его. |

## 📌 Lab 5: Interpreter









