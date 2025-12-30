package com.alvalabs.lookup.dto;

import com.fasterxml.jackson.annotation.JsonProperty;

public class DebtDetails {

    @JsonProperty("balance_of_debt")
    private int balanceOfDebt;

    private boolean complaints;

    public int getBalanceOfDebt() { return balanceOfDebt; }
    public boolean isComplaints() { return complaints; }
}