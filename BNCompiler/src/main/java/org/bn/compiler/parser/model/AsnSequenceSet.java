package org.bn.compiler.parser.model;

import java.util.ArrayList;
import java.util.List;

public class AsnSequenceSet {
    
    final String                BUILTINTYPE  = "SEQUENCE";
    final String                BUILTINTYPE1 = "SET";
    public List<AsnElementType> componentTypes;
    public boolean              isSequence;
    public String               name;    // Name of Sequence

    public AsnSequenceSet() {
        name           = "";
        isSequence     = false;
        componentTypes = new ArrayList<>();
    }

    @Override
    public String toString() {
        String ts = name;

        if (isSequence) {
            ts += "\t::=" + BUILTINTYPE + "\t";
        } else {
            ts += "\t::=" + BUILTINTYPE1 + "\t";
        }

        ts += "{";

        if (componentTypes != null) {
            for (AsnElementType elementType: componentTypes) {
                ts += elementType;
            }
        }

        ts += "}";

        return ts;
    }
}
