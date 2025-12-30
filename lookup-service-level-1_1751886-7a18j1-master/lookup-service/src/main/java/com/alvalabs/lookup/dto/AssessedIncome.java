package com.alvalabs.lookup.dto;

import com.fasterxml.jackson.annotation.JsonProperty;

public class AssessedIncome {

    @JsonProperty("assessed_income")
    private int assessedIncome;

    public int getAssessedIncome() {
        return assessedIncome;
    }
}