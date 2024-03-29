/********************************************************************************
 * Copyright (c) 2011-2017 Red Hat Inc. and/or its affiliates and others
 *
 * This program and the accompanying materials are made available under the 
 * terms of the Apache License, Version 2.0 which is available at
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * SPDX-License-Identifier: Apache-2.0 
 ********************************************************************************/
namespace six.core;

"""
Represents the machine and virtual machine on which the current process is executing.

Holds information about runtime name, version and about inherent limitations like minimum/maximum values that can be
represented by the runtime.
"""
see (value process, value language, value system, value operatingSystem)
tagged("Environment")
shared native("jvm") object runtime
{
    import java.lang { System, Long, Double, Int=Integer, Math }

    """
    A string that identifies the kind of virtual machine this process is executing:

    - `jvm` when executing a Java Virtual Machine,
    - `js` when executing any kind of JavaScript virtual machine, or
    - `dartvm` when executing the Dart VM.
    """
    shared native("jvm") String type => "jvm";
    
    """
    The name of the virtual machine this process is executing:
    
    - `jvm` when running on a Java Virtual Machine,
    - `node.js` when running on Node.js,
    - `Browser` when running in a web browser (if the `window` object exists), or
    - `DartVM` when running on the Dart VM.
    """
    deprecated ("Use [[type]]")
    shared native("jvm") String name => "jvm";
    
    "The version of the virtual machine this process is executing."
    shared native("jvm") String version => System.getProperty("java.specification.version");
    
    "The number of bits used to represent the value of an [[Integer]]."
    see (class Integer)
    shared native("jvm") Integer integerSize => 64;

    "The number of bits of [[Integer]] instances which may be manipulated via the methods inherited from [[Binary]]."
    shared native("jvm") Integer integerAddressableSize => 64;
    
    """
    The smallest [[Integer]] value that can be represented by the runtime.
    
    It is the minimum `Integer` that can be distinguished from its successor using below formula:
    
    `Integer(n-1) = Integer(n) - 1` with `Integer(0) = 0`
    """
    see (class Integer)
    shared native("jvm") Integer minIntegerValue => Long.minValue;

    """
    The largest [[Integer]] value that can be represented by the runtime.
    
    It is the maximum `Integer` that can be distinguished from its predecessor using below formula:
    
    `Integer(n+1) = Integer(n) + 1` with `Integer(0) = 0`
    """
    see (class Integer)
    shared native("jvm") Integer maxIntegerValue => Long.maxValue;
    
    """
    The maximum size of an [[Array]] that is possible for this runtime. Note that this is a theoretical limit only. In
    practice it is usually impossible to allocate an array of this size, due to memory constraints.
    """
    see (class Array)
    shared native("jvm") Integer maxArraySize = Int.maxValue - 8;
    
    "The largest finite [[Float]] value that can be represented by the runtime."
    shared native("jvm") Float maxFloatValue => Double.maxValue;

    "The smallest positive nonzero [[Float]] value that can be represented by the runtime."
    shared native("jvm") Float minFloatValue => Double.minValue;    
    
    "The _machine epsilon_ for [[floating point|Float]] values. That is, the smallest value `e` such that:
     
         1.0 + e > 1.0"
    shared native("jvm") Float epsilon = Math.ulp(1.0);
    
    """
    The largest [[Integer]] that can be exactly represented as a [[Float]] without loss of precision. The negative of
    this value is the smallest `Integer` that can be exactly represented as a `Float`.
    """
    see (value Integer.float)
    shared native("jvm") Integer maxExactIntegralFloat = 2^53-1;
    
    shared actual String string  => "runtime [``type`` / ``version``]";
}
