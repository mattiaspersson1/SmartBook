package com.alvalabs.lookup.dto;

import com.fasterxml.jackson.annotation.JsonProperty;

public class CreditData {

    @JsonProperty("first_name")
    private final String firstName;

    @JsonProperty("last_name")
    private final String lastName;

    private final String address;

    @JsonProperty("assessed_income")
    private final int assessedIncome;

    @JsonProperty("balance_of_debt")
    private final int balanceOfDebt;

    private final boolean complaints;

    public CreditData(
            String firstName,
            String lastName,
            String address,
            int assessedIncome,
            int balanceOfDebt,
            boolean complaints
    ) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.address = address;
        this.assessedIncome = assessedIncome;
        this.balanceOfDebt = balanceOfDebt;
        this.complaints = complaints;
    }

    public String getFirstName() { return firstName; }
    public String getLastName() { return lastName; }
    public String getAddress() { return address; }
    public int getAssessedIncome() { return assessedIncome; }
    public int getBalanceOfDebt() { return balanceOfDebt; }
    public boolean isComplaints() { return complaints; }
}