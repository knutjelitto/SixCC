/********************************************************************************
 * Copyright (c) 2011-2017 Red Hat Inc. and/or its affiliates and others
 *
 * This program and the accompanying materials are made available under the 
 * terms of the Apache License, Version 2.0 which is available at
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * SPDX-License-Identifier: Apache-2.0 
 ********************************************************************************/
import ceylon.language.impl {
    BaseIterable,
    BaseIterator
}

"Need a map-like thing, but can't use java.util.HashMap directly, 
 not ceylon.collection::HashMap"
native class NativeMap<Key,Element>() {
    shared native Element? get(Key id);
    shared native void put(Key id, Element instanceOrPartial);
    shared native Boolean contains(Key id);
    shared native {Key*} keys;
    shared native {Element*} items;
    shared native Integer size;
    shared native actual String string;
}


native("jvm") class NativeMap<Key,Element>() {
    
    import java.util {
        HashMap,
        JavaIterator=Iterator
    }
    native("jvm") HashMap<Key, Element> m = HashMap<Key, Element>();
    
    shared native("jvm") void put(Key id, Element instanceOrPartial) {
        m.put(id, instanceOrPartial);
    }
    
    shared native("jvm") Element? get(Key id) {
        return m.get(id of Object?);
    }
    
    shared native("jvm") Boolean contains(Key id) {
        return m.containsKey(id of Object?);
    }
    
    shared native("jvm") Integer size {
        return m.size();
    }
    
    shared native("jvm") Iterable<Element, Null> items {
        return object extends BaseIterable<Element,Null>() satisfies Identifiable {
            
            shared actual Iterator<Element> iterator() {
                JavaIterator<Element> it = m.values().iterator();
                return object extends BaseIterator<Element>() satisfies Identifiable {
                    
                    shared actual Element|Finished next() {
                        if (it.hasNext()) {
                            return it.next();
                        } else { 
                            return finished;
                        }
                    }
                };
            }
        };
    }
    
    
    shared native("jvm") Iterable<Key, Null> keys {
        return object extends BaseIterable<Key,Null>() satisfies Identifiable {
            
            shared actual Iterator<Key> iterator() {
                JavaIterator<Key> it = m.keySet().iterator();
                return object extends BaseIterator<Key>() satisfies Identifiable {
                    
                    shared actual Key|Finished next() {
                        if (it.hasNext()) {
                            return it.next();
                        } else { 
                            return finished;
                        }
                    }
                };
            }
        };
    }
    
    shared native("jvm") actual String string {
        return m.string;
    }
}
