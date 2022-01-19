/********************************************************************************
 * Copyright (c) 2011-2017 Red Hat Inc. and/or its affiliates and others
 *
 * This program and the accompanying materials are made available under the 
 * terms of the Apache License, Version 2.0 which is available at
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * SPDX-License-Identifier: Apache-2.0 
 ********************************************************************************/
import java.lang {
    Thread
}

"A Java [[java.lang::Thread]] that executes the given
 [[function|run]]."
shared class JavaThread(run) extends Thread() {
    "The function to execute."
    shared actual void run();
}