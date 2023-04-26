![mathemancy](https://github.com/Moreault/Mathemancy/blob/master/mathemancy.png)

# Mathemancy
A bundle for generic geometry types such as Vector2&lt;T>, Size&lt;T> and Rectangle&lt;T>

Have you ever had the pleasure of working with a game engine that had types such as RectangleFloat or RectangleInt? I have! And I find it kind of annoying. If only there was a way to have a generic Rectangle…

There is!

Have you ever wanted Size and/or Vector types? We have that too!

This library is still small but will (probably) get bigger with time.

## Variable names

a, b, c, m, x and y may be perfectly acceptable as variable names in mathematical theories and pieces of paper but it has no place in programming as it only serves to make code less readable. 

This library recognizes that not everyone may have a strong mathematical background and makes use of longer variable names to accomodate a wider range of developers.

Mathemancy thus follows the ToolBX philosophy that programming should never be a guessing game and code should speak for itself.

## Linear interpolation

As of Mathemancy 1.1.0, linear interpolation is part of Mathemancy.Interpolation.

You can also use the Mathematics class to interpolate between values. Most game engines already have these included (Lerp) but they are often misused by hobbyists because those engines seem to like to keep their code and documentation obfuscated for some reason.

```c#
public void DoSomeStuff()
{
	//Returns a value between 50 and 125 when the current progress is 40% (80)
	var currentValue = Interpolation.Calculate(50, 125, 0.4f);
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
		_position = Interpolation.Calculate(50, 125, _progress);
	}
}
```

## Conversion

### Numbers

Want to convert that Vector<float> into a Vector<int> but don't want to do this?

```c#
var newPosition = new Vector<int>((int)position.X, (int)position.Y);
```

You're in luck because you can just do this :

```c#
var newPosition = position.ToInt();
var newSize = size.ToDouble();
var newRectangle = rectangle.ToULong();
```

These extension methods are available for Vector2, Vector3, Rectangle and Size.

# Mathemancy.Randomness

Provides two random number generation (RNG) services : `PseudoRandomNumberGenerator` and `SecureRandomNumberGenerator`. Both of these services implement `IRandomNumberGenerator` and therefore have the exact same capabilities and are used in the same way.

## PseudoRandomGenerator
While more "predictable," this generator is also more performant than its "secure" cousin. It probably fits most needs for number generation but don't hesitate to try both and evaluate for yourself whether or not the pros outweigh the cons.

## SecureRandomNumberGenerator
Leverages .NET's cryptography libraries to give you a more "secure," less "predictable" generator. While less performant than the `PseudoRandomNumberGenerator`, both still generate random numbers in milliseconds with modern hardware. I would probably avoid using it in an update loop but it should be safe otherwise. 

## Getting started

If you already use [AutoInject] then you only need to inject IPseudoRandomNumberGenerator and/or ISecureRandomNumberGenerator to a class in order to use it.

If not, you can use the following method when injecting services :

```c#
services.AddRandomness();
```

If you don't use dependency injection at all then you can just instantiate the classes directly and use them.

# Breaking changes

Mathemancy 1.0.7 -> 1.1.0
* Linear interpolation has been moved to Mathemancy.Interpolation
* Mathematics.Interpolate and GetDelta for Vector2 are now extension methods

Mathemancy.Interpolation 2.0.0 -> 2.1.0
* The interpolation class was erroneously under the Mathemancy.Interpolation namespace and was moved to the ToolBX.Mathemancy.Interpolation namespace instead
* The class also had to be renamed Interpolator in order to avoid namespace clashes (for some reason this was okay without the 'ToolBX' prefix but no longer!)
* Version 2.0.1 has both Interpolation (with old namespace) and Interpolator (new namespace) in order to facilitate the move
