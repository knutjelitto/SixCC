/********************************************************************************
 * Copyright (c) 2011-2017 Red Hat Inc. and/or its affiliates and others
 *
 * This program and the accompanying materials are made available under the 
 * terms of the Apache License, Version 2.0 which is available at
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * SPDX-License-Identifier: Apache-2.0 
 ********************************************************************************/
"A queue with a native implementation"
native class NativeDeque() {
    shared native void pushFront(Anything element);
    shared native void pushBack(Anything element);
    shared native Anything popFront();
    shared native Boolean empty;
    shared actual native String string;
}

native("jvm") class NativeDeque() {
    import java.util {
        ArrayDeque,
        Deque
    }

    Deque<Anything> deque = ArrayDeque<Anything>();
    shared native("jvm") void pushFront(Anything element) {
        deque.addFirst(element);
    }
    shared native("jvm") void pushBack(Anything element) {
        deque.addLast(element);
    }
    shared native("jvm") Anything popFront() {
        return deque.pollFirst();
    }
    shared native("jvm") Boolean empty {
        return deque.empty;
    }
    shared actual native("jvm") String string {
        return deque.string;
    }
}
