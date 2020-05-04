import { TestBed } from '@angular/core/testing';

import { DevAuthService } from './dev-auth.service';

describe('DevAuthService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: DevAuthService = TestBed.get(DevAuthService);
    expect(service).toBeTruthy();
  });
});
