import React from 'react';
import { Switch, Route, BrowserRouter } from 'react-router-dom';

import Teams from './pages/Teams';
import Results from './pages/Results';

const Routes = () => (
    <BrowserRouter>
        <Switch>
            <Route exact path="/" component={Teams} />
            <Route exact path="/resultado" component={Results} />
        </Switch>
    </BrowserRouter>
)  

export default Routes;