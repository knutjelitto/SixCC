/********************************************************************************
 * Copyright (c) 2011-2017 Red Hat Inc. and/or its affiliates and others
 *
 * This program and the accompanying materials are made available under the 
 * terms of the Apache License, Version 2.0 which is available at
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * SPDX-License-Identifier: Apache-2.0 
 ********************************************************************************/
import java.nio
{
    JavaByteBuffer=ByteBuffer
    {
        allocateJavaByteBuffer=allocate
    }
}

"Represents a buffer of [[Byte]]s (from 0 to 255 inclusive, unsigned)."
by ("Stéphane Épardaud", "Alex Szczuczko")
shared native class ByteBuffer extends Buffer<Byte>
{
    "Allocates a new [[ByteBuffer]] filled with the given [[initialData]]. The capacity of the new
     buffer will be the number of bytes given. The returned buffer will be ready to be `read`, with
     its `position` set to `0` and its limit set to the buffer `capacity`."
    shared native new ({Byte*} initialData) extends Buffer<Byte>() {}
    
    "Creates a [[ByteBuffer]] initally backed by the given [[initialArray]]. The capacity of the
     new buffer will be the size of the array. The returned buffer will be ready to be `read`, with
     its `position` set to `0` and its limit set to the buffer `capacity`."
    shared native new ofArray(Array<Byte> initialArray) extends Buffer<Byte>() {}
    
    "Allocates a new zeroed [[ByteBuffer]] of the given [[initialCapacity]]."
    shared native new ofSize(Integer initialCapacity) extends Buffer<Byte>() {}
    
    shared actual native Integer capacity;
    shared actual native void clear();
    shared actual native void flip();
    shared actual native Byte get();
    shared actual native Object? implementation;
    shared actual native variable Integer limit;
    shared actual native variable Integer position;
    shared actual native void put(Byte element);
    shared actual native void resize(Integer newSize, Boolean growLimit);
    shared actual native Array<Byte> array;
}

shared native ("jvm") class ByteBuffer extends Buffer<Byte>
{
    variable JavaByteBuffer buf;
    
    shared native ("jvm") new ({Byte*} initialData) extends Buffer<Byte>()
    {
        buf = allocateJavaByteBuffer(initialData.size);
        initialData.each(void(byte) => buf.put(byte));
        buf.clear();
    }
    
    shared native ("jvm") new ofArray(Array<Byte> initialArray) extends Buffer<Byte>()
    {
        buf = allocateJavaByteBuffer(initialArray.size);
        initialArray.each(void(byte) => buf.put(byte));
        buf.clear();
    }
    
    shared native ("jvm") new ofSize(Integer initialCapacity) extends Buffer<Byte>()
    {
        buf = allocateJavaByteBuffer(initialCapacity);
    }
    
    shared actual native ("jvm") Integer capacity => buf.capacity();
    
    shared actual native ("jvm") Integer limit => buf.limit();
    native ("jvm") assign limit
    {
        "Limit must be non-negative"
        assert (limit >= 0);
        "Limit must be no larger than capacity"
        assert (limit <= capacity);
        buf.limit(limit);
    }
    
    shared actual native ("jvm") Integer position => buf.position();
    native ("jvm") assign position
    {
        "Position must be non-negative"
        assert (position >= 0);
        "Position must be no larger than limit"
        assert (position <= limit);
        buf.position(position);
    }
    
    shared actual native ("jvm") Byte get()
    {
        if (position > limit)
        {
            throw BufferUnderflowException("No byte at position ``position``");
        }
        return buf.get();
    }

    shared actual native ("jvm") void put(Byte element)
    {
        if (position > limit)
        {
            throw BufferOverflowException("No space at position ``position``");
        }
        buf.put(element);
    }
    
    shared actual native ("jvm") void clear() => buf.clear();
    shared actual native ("jvm") void flip() => buf.flip();
    
    shared actual native ("jvm") void resize(Integer newSize, Boolean growLimit)
    {
        resizeBuffer {
            newSize = newSize;
            growLimit = growLimit;
            current = this;
            intoNew = () {
                // copy
                value dest = allocateJavaByteBuffer(newSize);
                dest.put(buf);
                // change buffer
                buf = dest;
            };
        };
    }
    
    shared actual native ("jvm") Array<Byte> array => buf.array().byteArray;
    shared actual native ("jvm") Object? implementation => buf;
}
