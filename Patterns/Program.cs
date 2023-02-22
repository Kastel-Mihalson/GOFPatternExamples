﻿using AdapterPattern;
using BuilderPattern;
using BuilderPatternV2;
using BuilderPatternV3;
using CommandPattern;
using DecoratorPattern;
using DecoratorPatternV2;
using FacadePattern;
using FactoryPattern;
using IteratorPattern;
using IteratorPatternV2;
using MediatorPattern;
using ObserverPattern;
using PrototypePattern;
using ProxyPattern;
using SingletonPattern;
using StatePattern;
using StrategyPattern;
using System;
using VisitorPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
         Паттер Builder (Строитель) можно представить как Бургер.
        У бургера есть много состовляющих компонентов: сыр, помидор, мясо, огурец, лук и т.д.
        Для приготовления тех или иных бургеров некоторые компоненты не нужны.
        Поэтому для приготовления простого бургера с котлетов достаточно: 
        (пример FluentBuilder, без класса Director/Creator)

        var burger = builder
            .SetBecon()
            .GetResult();

        Для приготовления бургера с помидором, сыром и оругцами:
        var burger = builder
            .SetTomat()
            .SetCheese()
            .SetCucumbers()
            .GetResult();
         */
        #region BUILDER pattern examples

        //new TestBuilderPattern().Execute();
        //new TestBuilderPatternV2().Execute();
        //new TestBuilderPatternV3().Execute();

        #endregion

        /*
         Паттерн Singleton (Одиночка) хорошо представить как общие настройки игры.
        В проекте игры есть необходимость получить или установить те или иные
        настройки игры. Для получения экземпляра настроек отовсюду можно сделать его статическим классом.
        Но лучше сделать его синглтоном. Отличия статического от синглтона можно почитать на сайте.
         */
        #region SINGLETON pattern example

        //new TestSingletonPattern().Execute();

        #endregion

        /*
         Паттерн Prototype (Прототип) нужен для создания дубликата.
        Реализованы методы клонирования объекта и глубокого клонирования.
         */
        #region PROTOTYPE pattern

        //new TestPrototypePattern().Execute();

        #endregion

        /*
         Паттерн Factory (Фабричный метод) можно представить на примере игры про космический корабль.
        В магазине оружия мы можем выбрать, какой тип оружия установить.
        На момент запуска игры экземпляры оружия не инициализированы. Они создаются в
        момент выбора конкретного оружия. 
        Есть фабрика SpaceshipGunFactory с методом получения продукта GetSpaceshipGun() возвращающий интерфейс ISpaceshipGun,
        есть фабрики конретных продуктов LaserGunFactory() : SpaceshipGunFactory, наследующиеся от фабрики
        есть сами продукты LaserGun : ISpaceshipGun, наследующие от интерфейса
         */
        #region FACTORY pattern example

        //new TestFactoryPattern().Execute();

        #endregion

        /*
         Паттерн Facade (Фасад) можно представить как запуск сложной системы,
        конечным пользователем. Он не должен ничего знать о том, как и что
        запускается, а просто нажаить Start или Run. Под капотом этого
        метода кроется многообразие вызовов методов, сложных систем. 
        Фасад скрывает всю реализацию сложной системы и упрощает её использование.
         */
        #region FACADE pattern example

        //new TestFacadePattern().Execute();

        #endregion

        /*
         * СТРУКТУРНЫЙ ШАБЛОН
         Паттерн Proxy (Заместитель) - прослойка между основным ресурсом и клиентом.
        Различают 4 вида прокси: 
        Удаленный - имитация поведения ресурса, кеширование и логирование, 
        Виртуальный - создание объекта происходит в момент обращения (ленивая инициализация),
        Защищающий - разграничение доступа в зависимости от прав клиента,
        Умные ссылки - ...

        В данном примере реализована имитация отображения статуса заказа в кафе.
        (Смотреть в методе Execute())
        Без прокси - данные для отображения загружаются долго.
        С прокси - данные статусов кешируются и подгружаются мгновенно.
         */
        #region PROXY pattern example

        //new TestProxyPattern().Execute();

        #endregion

        /*
         Паттерн Iterator (Итератор) для перебора объектов без раскрытия внутренней структуры.
         */
        #region ITERATOR pattern example

        //new TestIteratorPattern().Execute();
        //new TestIteratorPatternV2().Execute();

        #endregion

        /*
         Паттерн Observer (Наблюдатель) можно сравнить с видеохостингом YouTube.
        Есть канал, который выпускает ролики - автор канала, есть подписчики, 
        которые подписываются на разные каналы и им приходят уведомления о новых видео.

        Observable - канал автора (Наблюдаемый объект), observer - подписчики (Наблюдатели)
        Класс, который реализует интерфейс Observable содержит в себе список подписчиков,
        метод для подписки на канал, метод для отписка от канала, и метод оповещения всех
        подписчиков о новостях.

        Класс, который реализует интерфейс Observer содержит в себе (в данном примере)
        Подписку на канал, в параметр который передается канал, отписка от канала с таким
        же параметром и метод Update, который отрабатывает при получения уведомления о новостях.
         */
        #region OBSERVER pattern example

        //new TestObserverPattern().Execute();

        #endregion

        /*
         Паттерн Медиатор (Посредник) можно представить как диспетчерскую в аэродроме, которая
        регулирует всех находяшихся в воздушном пространстве. Вместо того, чтобы один пилот самолета напрямую общался
        с другим пилотом воздушного транспорта, он обращается в диспетчерскую. Тем самым диспетчерская
        выступает в роли посредника между всеми.

        Есть абстрактный класс Mediator (диспетчерская) с методом Send.
        Реализация класса Медиатора - содержит в себе всех Colleague (воздушные транспорты),
        и когда вызывается метод Send, то вызывает у другого отпределенного воздушного судна метод Notify,
        чтобы доставить уведомление.

        Есть абстрактный класс Collegue (воздушный транспорт). 
        - У него есть ссылка на класс Mediator (якобы номер, чтобы позвонить в диспетчерскую).
        - Метод Send, сообщение которого пересылается методу Send медиатора-диспетчера. также попутно
          передавая отправителя.
        - Метод Notify, который уведомляет воздушный транспорт, что пришло сообщение.
         */
        #region MEDIATOR pattern example

        //new TestMediatorPattern().Execute();

        #endregion

        /*
         Паттерн State (Состояние) можно представить как светофор. У светофора есть 3 состояния,
        красный желтый зеленый. Операция по смене состояния будет одна.
        В итоге при вызове метода изменения будет происходить смена статуса на следующий.
        При повторном вызове того же метода будет снова происходить изменение уже измененного
        статуса на другой статус.

        Также можно представить и воду. У воды 3 состояния, твердое, жидкое, газообразное.
        В этом случае уже определяем две операции. Нагревание и Охлаждение.
        Для каждого экземпляра определяем поведение и изменяем статус в соответствии с логикой.
         */
        #region STATE pattern example

        //new TestStatePattern().Execute();

        #endregion

        /*
         Паттерн Decorator (Декторатор) подобен паттерну Builder. Возмем к примеру, два типа бургера,
        и каждого бургега будет 4 параметр добавления ингредиента: бекон, томат, сыр, огурец.
        2 типа на 4 свойства = 8 разных классов. Чтобы не городить большое количество классов,
        можем вынести общие классы, отвечающие отдельно за бургер, и отдельно за добавление добавок.

        При создании бургера одного типа, можем декорировать его дополнительными ингредиентами:
        Buger simpleBurger = new SimpleBurger();
        simpleBurger = new TomatBurger(simpleBurger);
        simpleBurger = new BeconBurger(simpleBurger);
        Сначала создается просто булочка, затем декорируется томатом, а после дополнительно
        декорируется беконом. 
        Цена бургера при добавлении каждого свойства бужет меняться.
         */
        #region DECORATOR pattern example

        //new TestDecoratorPattern().Execute();
        //new TestDecoratorPatternV2().Execute();

        #endregion

        /*
         Паттерн Strategy (Стратегия) вероятно использовал каждый не зная о нем самом.
        Можно представить как смена оружия в космического корабля. В конструктор класса корабля передаем
        экземпляр класса пушки, который реализует интерфейс орудия. В классе корабля вызывается
        метод стрельбы от переданного экземпляра пушки. Реализуется способом агрегации.
         */
        #region STRATEGY pattern example

        //new TestStrategyPattern().Execute();

        #endregion

        /*
         Паттерн Adapter (Адаптер) можно далеко не ходить и представить адаптер под
        разные порта носителей информации. В ноутбуке есть порт USB для флешек, но нет порта
        для MicroSD, к примеру. В данном случае, чтобы получить данные с MicroSD нужно использовать адаптер,
        у которого есть вход для подключения к USB порту и имеется порт под MicroSD. Далее просто вставляем адаптер
        в ноут и радуемся жизни.
         */
        #region ADAPTER pattern example

        //new TestAdapterPattern().Execute();

        #endregion

        /*
         Паттер Visitor (Посетитель) сложный для представления.
        Пример не самый удачный.
        Фигурируют элементы паттерна: 
        - Интерфейс IElement с методом, к примеру: Execute(IVisitor executeEvent)
        - Элементы от интерфейса IElement с разными данными, у которых 
          в методе Execute вызывается конкретный метод из интерфейса IVisitor.
        - Интерфейс IVisitor (События/Эвенты-мероприятия) у которых есть методы, 
          относящиеся ко всем типов элементов. К примеру:
          
          Допустим есть три класса наследующие интейрфейс IElement
          CGDrawer : IElement,
          TradDrawer : IElement,
          StranDrawer : IElement

          То у интерфейса IVisitor методы:
          void CGDrawMethod(CGDrawer drawer);
          void TradDrawMethod(TradDrawer drawer);
          void StranDrawMethod(StranDrawer drawer);
          
        - Элементы от интерфейса IVisitor
        - Элемент школы, содержащий методы добавления и удаления элементов в список,
          а также метод с параметром IVisitor, который в цикле перебирает элементы и выполняет у них метод Execute
          передавая посетителя из параметров.
          
         */
        #region VISITOR pattern example

        //new TestVisitorPattern().Execute();

        #endregion

        /*
         Паттерн Command (Команда) хорошо можно проиллюстрировать на основе игры.
        Есть разные юниты, у них есть команды. Каждую определенную команду можно применить к юниту.
        Элементы:
        - интерфейс ICommand - определены методы Execute() и Cancel()
        - интерфейс IUnit - определены какие действия может выполнять юнти. Walk(), Attack(), Jump()...
        - реализация интерфейса для конкретной команды, WalkCommand : ICommand
          и пишем, что произойдет при вызове Execute для WalkCommand и при вызове Cancel.
          принимает параметр IUnit, для которого нужно выполнять команду.
        - реализация интерфейса IUnit для конкретного персонажа RunnerUnit : IUnit
          для которого пишем, что будет происходить при вызовах методов  Walk(), Attack(), Jump()...
        - класс Invoker, который будет принимать команду и вызывать у него Execute и Cancel.
         */
        #region COMMAND pattern example

        //new TestCommandPattern().Execute();

        #endregion
    }
}