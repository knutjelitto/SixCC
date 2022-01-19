/********************************************************************************
 * Copyright (c) 2011-2017 Red Hat Inc. and/or its affiliates and others
 *
 * This program and the accompanying materials are made available under the 
 * terms of the Apache License, Version 2.0 which is available at
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * SPDX-License-Identifier: Apache-2.0 
 ********************************************************************************/
"Represents the current process (instance of the virtual
 machine)."
by ("Gavin", "Tako")
see (value language, value runtime, value system,
     value operatingSystem)
tagged("Environment")
shared native object process {
    
    "The command line arguments to the virtual machine."
    shared native String[] arguments;
    
    "Determine if an argument of form `-name` or `--name` 
     was specified among the command line arguments to 
     the virtual machine."
    shared native Boolean namedArgumentPresent(String name);

    "The value of the first argument of form `-name=value`, 
     `--name=value`, or `-name value` specified among the 
     command line arguments to the virtual machine, if
     any."
    shared native String? namedArgumentValue(String name);

    "The value of the given system property of the virtual
     machine, if any."
    shared native String? propertyValue(String name);

    "The value of the given environment variable defined 
     for the current virtual machine process."
    since("1.2.0")
    shared native String? environmentVariableValue(String name);
    
    "Print a string to the standard output of the virtual
     machine process."
    shared native void write(String string);
    
    "Print a line to the standard output of the virtual 
     machine process."
    see (function print)
    shared void writeLine(String line="") { 
        write(line);
        write(operatingSystem.newline); 
    }
    
    "Flush the standard output of the virtual machine 
     process."
    shared native void flush();
    
    "Print a string to the standard error of the virtual 
     machine process."
    shared native void writeError(String string);
    
    "Print a line to the standard error of the virtual 
     machine process."
    shared void writeErrorLine(String line="") { 
        writeError(line);
        writeError(operatingSystem.newline);
    }
    
    "Flush the standard error of the 
     virtual machine process."
    shared native void flushError();
    
    "Read a line of input text from the standard input of 
     the virtual machine process. Returns a line of text 
     after removal of line-termination characters, or `null`
     to indicate the standard input has been closed."
    shared native String? readLine();
    
    "Force the virtual machine to terminate with the given
     exit code."
    shared native Nothing exit(Integer code);
    
    shared actual String string => "process";
    
    String? namedArgumentValueInternal(String name) {
        if (name.empty) {
            return null;
        }
        value args = arguments;
        for (i in 0:args.size) {
            assert (exists arg = args[i]);
            if (arg.startsWith("-``name``=")) {
                return arg.removeInitial("-``name``=");
            }
            if (arg.startsWith("--``name``=")) {
                return arg.removeInitial("--``name``=");
            }
            if (arg == "-" + name || 
                arg == "--" + name) {
                return 
                if (exists next = args[i+1],
                    !next.startsWith("-"))
                then next
                else null;
            }
        }
        else {
            return null;
        }
    }
    
    Boolean namedArgumentPresentInternal(String name) {
        if (name.empty) {
            return false;
        }
        for (arg in arguments) {
            if (arg.startsWith("-``name``=") || 
                arg.startsWith("--``name``=") || 
                    arg == "-" + name || 
                    arg == "--" + name) {
                return true;
            }
        }
        else {
            return false;
        }
    }
    
}

shared native("jvm") object process {
    import java.lang {
        System {
            output = \iout,
            input = \iin,
            error = err
        }
    }
    import java.io {
        BufferedReader,
        InputStreamReader,
        IOException
    }
    
    shared native("jvm") String[] arguments 
            => vmArguments.sequence();
    
    shared native("jvm") void write(String string) 
            => output.print(string);
    
    shared native("jvm") void writeError(String string) 
            => error.print(string);
    
    shared native("jvm") void flush() => output.flush();
    
    shared native("jvm") void flushError() => error.flush();
    
    late value stdinReader 
            = BufferedReader(InputStreamReader(input));
    
    shared native("jvm") String? readLine() {
        try {
            return stdinReader.readLine();
        } 
        catch (IOException e) {
            throw Exception("could not read line from standard input", e);
        }
    }
    
    shared native("jvm") Nothing exit(Integer code) {
        System.exit(code);
        return nothing;
    }
    
    shared native("jvm") String? namedArgumentValue(String name)
            => namedArgumentValueInternal(name);
    
    shared native("jvm") Boolean namedArgumentPresent(String name)
            => namedArgumentPresentInternal(name);
    
    shared native("jvm") String? propertyValue(String name) 
            => if (name.empty) then null 
            else System.getProperty(name);

    shared native("jvm") String? environmentVariableValue(String name) 
            => if (name.empty) then null 
            else System.getenv(name);
    
}
