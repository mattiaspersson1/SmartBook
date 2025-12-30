package com.alvalabs.lookup.service;

import com.alvalabs.lookup.client.CreditDataClient;
import com.alvalabs.lookup.dto.*;
import com.alvalabs.lookup.exception.CreditDataNotFoundException;
import org.springframework.stereotype.Service;

@Service
public class LookupService {

    private final CreditDataClient creditDataClient;

    public LookupService(CreditDataClient creditDataClient) {
        this.creditDataClient = creditDataClient;
    }

    public CreditData getCreditData(String ssn) {

        PersonalDetails personal = creditDataClient.getPersonalDetails(ssn);
        DebtDetails debt = creditDataClient.getDebtDetails(ssn);
        AssessedIncome income = creditDataClient.getAssessedIncome(ssn);

        if (personal == null && debt == null && income == null) {
            throw new CreditDataNotFoundException();
        }

        return new CreditData(
                personal != null ? personal.getFirstName() : null,
                personal != null ? personal.getLastName() : null,
                personal != null ? personal.getAddress() : null,
                income != null ? income.getAssessedIncome() : 0,
                debt != null ? debt.getBalanceOfDebt() : 0,
                debt != null && debt.isComplaints()
        );
    }
}