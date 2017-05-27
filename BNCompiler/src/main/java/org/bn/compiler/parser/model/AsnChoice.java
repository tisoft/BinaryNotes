package org.bn.compiler.parser.model;

import java.util.ArrayList;
import java.util.List;

public class AsnChoice {
    
    final String                BUILTINTYPE = "CHOICE";
    public List<AsnElementType> componentTypes;
    public String               name;
    public final boolean        isChoice = true;

    public AsnChoice() {
        name           = "";
        componentTypes = new ArrayList<>();
    }

    @Override
    public String toString() {
        String ts = name + "\t::=\t" + BUILTINTYPE + "\t {";

        if (componentTypes != null) {
            for (AsnElementType elementType: componentTypes) {
                ts += elementType;
            }
        }

        ts += "}";

        return ts;
    }
}
