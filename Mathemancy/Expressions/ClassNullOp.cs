/*
"Miscellaneous Utility Library" Software Licence

Version 1.0

Copyright (c) 2004-2008 Jon Skeet and Marc Gravell.
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions
are met:

1. Redistributions of source code must retain the above copyright
notice, this list of conditions and the following disclaimer.

2. Redistributions in binary form must reproduce the above copyright
notice, this list of conditions and the following disclaimer in the
documentation and/or other materials provided with the distribution.

3. The end-user documentation included with the redistribution, if
any, must include the following acknowledgment:

"This product includes software developed by Jon Skeet
and Marc Gravell. Contact skeet@pobox.com, or see 
http://www.pobox.com/~skeet/)."

Alternately, this acknowledgment may appear in the software itself,
if and wherever such third-party acknowledgments normally appear.

4. The name "Miscellaneous Utility Library" must not be used to endorse 
or promote products derived from this software without prior written 
permission. For written permission, please contact skeet@pobox.com.

5. Products derived from this software may not be called 
"Miscellaneous Utility Library", nor may "Miscellaneous Utility Library"
appear in their name, without prior written permission of Jon Skeet.

THIS SOFTWARE IS PROVIDED "AS IS" AND ANY EXPRESSED OR IMPLIED
WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF
MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.
IN NO EVENT SHALL JON SKEET BE LIABLE FOR ANY DIRECT, INDIRECT,
INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING,
BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT
LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN
ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
POSSIBILITY OF SUCH DAMAGE. 
*/

//The following code was taken from Jon Skeet and Marc Gravell's MiscUtil library

namespace ToolBX.Mathemancy.Expressions;

internal sealed class ClassNullOp<T> : INullOp<T> where T : class
{
    public bool HasValue(T value)
    {
        return value != null;
    }

    public bool AddIfNotNull(ref T accumulator, T value)
    {
        if (value == null)
            return false;
        accumulator = accumulator == null ? value : Operator<T>.Add(accumulator, value);
        return true;
    }
}