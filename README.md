### Система оружия
Оружие является prefab'ом, который нужно добавить к игроку или мобу

![](https://sun9-46.userapi.com/c857628/v857628354/1c52d6/8YxGk_ZLpvs.jpg)
![](https://sun9-46.userapi.com/c857628/v857628354/1c52e4/VOjEdbHqDmA.jpg)

Каждое оружие стреляет снарядами, у снарядов есть свои характеристики (скорость полета и урон):

![](https://sun9-62.userapi.com/c857628/v857628354/1c52ed/a_0pQEwbH4s.jpg)

Характеристики снарядов можно переопределить в оружии, также настраивается скорость стрельбы (выстрелов в секунду, то есть ```AttacksPerSecond``` = 0.5 означает 1 атаку раз в 2 секунды):

![](https://sun9-62.userapi.com/c857628/v857628354/1c52dd/V0PgQA5kz6s.jpg)

Появление врагов контролирует **Enemy Controller**. \
В нем можно выбрать prefab врагов, а также настоить их количество и высоту спауна.

![](https://sun9-2.userapi.com/c857628/v857628354/1c52f4/0QOMENS9kEE.jpg)

Враги появляются случайным образом сверху в 2/3 игрового поля, каждый в своём боксе, размер бокса - ```SpawnBoxSize```. \
При выборе **Enemy Controller**'a во время PlayMode можно посмотреть сгенерированные спаун-боксы

![](https://sun9-47.userapi.com/c857628/v857628354/1c536c/BLXQV-N3Z9U.jpg)

Каждый враг содержит компонент ```EnemyData```, в котором указано вознаграждение за убийство и скорость его передвижения.
Компонент ```EnemyCreature``` отвечает за здоровье моба.

![](https://sun9-19.userapi.com/c857628/v857628354/1c52fb/FYXtPsIMKdk.jpg)

Так как наземный враг использует для передвижения **NavMesh**, его скорость контролируется в **NavMeshAgent** компоненте.
+ NavMeshAgent
  + Steering
    + Speed
    
![](https://sun9-40.userapi.com/c857628/v857628354/1c5302/SMqu0KsmR2M.jpg)

Также в нижнем правом углу есть кнопки переключения оружия - стреляющее одиночными или тройными снарядами

![](https://sun9-45.userapi.com/c857628/v857628354/1c5309/6CsWm0iNohY.jpg)

А при клике в нижний левый угол появляется альтернативный метод управления - вирнуальный джойстик

![](https://sun9-62.userapi.com/c857628/v857628354/1c53c2/Yment8V9kZo.jpg)


