![mathemancy](https://github.com/Moreault/Mathemancy/blob/master/mathemancy.png)

# Mathemancy
A bundle for generic geometry types such as Vector2&lt;T>, Size&lt;T> and Rectangle&lt;T>

Have you ever had the pleasure of working with a game engine that had types such as RectangleFloat or RectangleInt? I have! And I find it kind of annoying. If only there was a way to have a generic Rectangle…

There is!

Have you ever wanted Size and/or Vector types? We have that too!

This library is still small but will (probably) get bigger with time.

Most (all of it, really) of the logic for generic numeric operators was adapted to .NET 6 from Marc Gravell and Jon Skeet's https://jonskeet.uk/csharp/miscutil/

## Variable names

a, b, c, m, x and y may be perfectly acceptable as variable names in mathematical theories and pieces of paper but it has no place in programming as it only serves to make code less readable. 

This library recognizes that not everyone may have a strong mathematical background and makes use of longer variable names to accomodate a wider range of developers.

Mathemancy thus follows the ToolBX philosophy that programming should never be a guessing game and code should speak for itself.

## Linear interpolation

You can also use the Mathematics class to interpolate between values. Most game engines already have these included (Lerp) but they are often misused by hobbyists because those engines seem to like to keep their code and documentation obfuscated for some reason.

```c#
public void DoSomeStuff()
{
	//Returns a value between 50 and 125 when the current progress is 40% (80)
	var currentValue = Mathematics.Interpolate(50, 125, 0.4f);
}
```

You'll usually want to use linear interpolation in a repeating method such as a game loop for instance.

```c#
private float _progress;
private float _speed;
private float _elapsedTime;

private float _position;

//In this example, an object's _position would gradually move from 50 towards 125
public void Update(float deltaTime)
{
	if (_progress < 1)
	{
		_elapsedTime += deltaTime;
		_progress = _elapsedTime * deltaTime * _speed;
		_position = Mathematics.Interpolate(50, 125, _progress);
	}
}
```