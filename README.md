RadialMenu
===========

A custom control to create radial-menu into your WPF application.

![RadialMenu Demo](https://raw.githubusercontent.com/Julien-Marcou/RadialMenu/master/Resources/RadialMenu.gif)

How to use
-----------

Import the RadialMenu.dll into your project (do not forget to reference it),
then into your Xaml View, import the custom control

    xmlns:Controls="clr-namespace:RadialMenu.Controls;assembly=RadialMenu"

To create the **main component** of the RadialMenu, simply type

```xml
<Controls:RadialMenu>
    ...
</Controls:RadialMenu>
```

To create the **central menu item** of the RadialMenu, simply type

```xaml
<Controls:RadialMenuCentralItem>
    ...
</Controls:RadialMenuCentralItem>
```

To create a **menu item** of the RadialMenu, simply type

```xaml
<Controls:RadialMenuItem>
    ...
</Controls:RadialMenuItem>
```

Full example
-----------

A tipical example of what can be done

```xaml
<RadialMenu:RadialMenu IsOpen="{Binding IsOpen}">

    <!-- CentralMenuItem -->

    <RadialMenu:RadialMenu.CentralItem>
        <RadialMenu:RadialMenuCentralItem Command="{Binding CloseRadialMenuCommand}">
            <TextBlock>Close</TextBlock>
        </RadialMenu:RadialMenuCentralItem>
    </RadialMenu:RadialMenu.CentralItem>

    <!-- MenuItems Around -->

    <RadialMenu:RadialMenuItem Command="{Binding NewFileCommand}">
        <TextBlock>New file</TextBlock>
    </RadialMenu:RadialMenuItem>

    <RadialMenu:RadialMenuItem Command="{Binding EditCommand}">
        <TextBlock>Edit</TextBlock>
    </RadialMenu:RadialMenuItem>

    <RadialMenu:RadialMenuItem Command="{Binding SaveCommand}">
        <TextBlock>Save</TextBlock>
    </RadialMenu:RadialMenuItem>

    <RadialMenu:RadialMenuItem Command="{Binding DeleteCommand}">
        <TextBlock>Delete</TextBlock>
    </RadialMenu:RadialMenuItem>

    <RadialMenu:RadialMenuItem Command="{Binding ExitCommand}">
        <TextBlock>Exit</TextBlock>
    </RadialMenu:RadialMenuItem>

    <!-- Add items as you want... -->

</RadialMenu:RadialMenu>
```

which results in

![RadialMenu Example](https://raw.githubusercontent.com/Julien-Marcou/RadialMenu/master/Resources/RadialMenuExample.png)

Customization
-----------

You can even create your own style of RadialMenu (do not forget to add style for `disabled`, `hovered` and `pressed` item states if desired)

```xaml
<Style x:Key="FancyRadialMenuCentralItem" TargetType="Controls:RadialMenuCentralItem" BasedOn="{StaticResource {x:Type Controls:RadialMenuCentralItem}}">

    <Setter Property="Background" Value="AliceBlue"/>
    <Setter Property="BorderBrush" Value="DarkBlue"/>
    <Setter Property="BorderThickness" Value="4"/>
    <Setter Property="Width" Value="64"/>
    <Setter Property="Height" Value="64"/>

</Style>

<Style x:Key="FancyRadialMenuItem" TargetType="Controls:RadialMenuItem" BasedOn="{StaticResource {x:Type Controls:RadialMenuItem}}">

    <Setter Property="Background" Value="AliceBlue"/>
    <Setter Property="Padding" Value="2"/>
    <Setter Property="InnerRadius" Value="40"/>
    <Setter Property="OuterRadius" Value="150"/>
    <Setter Property="ContentRadius" Value="85"/>

    <Setter Property="EdgeBackground" Value="DarkBlue"/>
    <Setter Property="EdgePadding" Value="7"/>
    <Setter Property="EdgeInnerRadius" Value="130"/>
    <Setter Property="EdgeOuterRadius" Value="145"/>

    <Setter Property="ArrowBackground" Value="Cyan"/>
    <Setter Property="ArrowRadius" Value="138"/>

</Style>
```

which results in

![RadialMenu Custom](https://raw.githubusercontent.com/Julien-Marcou/RadialMenu/master/Resources/RadialMenuCustom.png)
