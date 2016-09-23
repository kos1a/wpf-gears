# wpf-gears
WPF spinning gear control.


### Usage ###


```
  <local:GearsView x:Name="gears" HorizontalAlignment="Left" VerticalAlignment="Top" RenderTransformOrigin="0.5,0.5">
            <local:GearsView.Effect>
                <DropShadowEffect/>
            </local:GearsView.Effect>
            <local:GearsView.RenderTransform>
                <TransformGroup>
                    <ScaleTransform ScaleX="0.5" ScaleY="0.5"/>
                    <SkewTransform/>
                    <RotateTransform/>
                    <TranslateTransform/>
                </TransformGroup>
            </local:GearsView.RenderTransform>
        </local:GearsView>
```

And then to start animation:


```
gears.StartAnim();
```
