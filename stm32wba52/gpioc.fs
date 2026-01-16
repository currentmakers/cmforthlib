\
\ @file gpioc.fs
\ @brief General-purpose I/Os
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief GPIO port C mode register
\ Address offset: 0x00
\ Reset value: 0xFC000000
\

$0c000000 constant GPIOC_GPIOC_MODER_MODE13                         \ Port C configuration I/O pin 13
$30000000 constant GPIOC_GPIOC_MODER_MODE14                         \ Port C configuration I/O pin 14
$c0000000 constant GPIOC_GPIOC_MODER_MODE15                         \ Port C configuration I/O pin 15 These bits are written by software to configure the I/O mode. Access can be protected by GPIOC SEC15.


\
\ @brief GPIO port C output type register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00002000 constant GPIOC_GPIOC_OTYPER_OT13                          \ Port C configuration I/O pin y These bits are written by software to configure the I/O output type. Access can be protected by GPIOC SECy.
$00004000 constant GPIOC_GPIOC_OTYPER_OT14                          \ Port C configuration I/O pin y These bits are written by software to configure the I/O output type. Access can be protected by GPIOC SECy.
$00008000 constant GPIOC_GPIOC_OTYPER_OT15                          \ Port C configuration I/O pin y These bits are written by software to configure the I/O output type. Access can be protected by GPIOC SECy.


\
\ @brief GPIOC port output speed register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0c000000 constant GPIOC_GPIOC_OSPEEDR_OSPEED13                     \ Port C configuration I/O pin 13
$30000000 constant GPIOC_GPIOC_OSPEEDR_OSPEED14                     \ Port C configuration I/O pin 14
$c0000000 constant GPIOC_GPIOC_OSPEEDR_OSPEED15                     \ Port C configuration I/O pin 15 These bits are written by software to configure the I/O output speed. Access can be protected by GPIOC SEC15. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.


\
\ @brief GPIO port C pull-up/pull-down register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0c000000 constant GPIOC_GPIOC_PUPDR_PUPD13                         \ Port C configuration I/O pin 13
$30000000 constant GPIOC_GPIOC_PUPDR_PUPD14                         \ Port C configuration I/O pin 14
$c0000000 constant GPIOC_GPIOC_PUPDR_PUPD15                         \ Port C configuration I/O pin 15 These bits are written by software to configure the I/O pull-up or pull-down Access can be protected by GPIOC SEC15.


\
\ @brief GPIO port C input data register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00002000 constant GPIOC_GPIOC_IDR_ID13                             \ Port C input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Access can be protected by GPIOC SECy.
$00004000 constant GPIOC_GPIOC_IDR_ID14                             \ Port C input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Access can be protected by GPIOC SECy.
$00008000 constant GPIOC_GPIOC_IDR_ID15                             \ Port C input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Access can be protected by GPIOC SECy.


\
\ @brief GPIO port C output data register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00002000 constant GPIOC_GPIOC_ODR_OD13                             \ Port C output data I/O pin y These bits can be read and written by software. Access can be protected by GPIOC SECy. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOC_BSRR or GPIOC_BRR registers.
$00004000 constant GPIOC_GPIOC_ODR_OD14                             \ Port C output data I/O pin y These bits can be read and written by software. Access can be protected by GPIOC SECy. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOC_BSRR or GPIOC_BRR registers.
$00008000 constant GPIOC_GPIOC_ODR_OD15                             \ Port C output data I/O pin y These bits can be read and written by software. Access can be protected by GPIOC SECy. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOC_BSRR or GPIOC_BRR registers.


\
\ @brief GPIO port C bit set/reset register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00002000 constant GPIOC_GPIOC_BSRR_BS13                            \ Port C set I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOC SECy.
$00004000 constant GPIOC_GPIOC_BSRR_BS14                            \ Port C set I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOC SECy.
$00008000 constant GPIOC_GPIOC_BSRR_BS15                            \ Port C set I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOC SECy.
$20000000 constant GPIOC_GPIOC_BSRR_BR13                            \ Port C reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOC SECy. Note: If both BSy and BRy are set, BSy has priority.
$40000000 constant GPIOC_GPIOC_BSRR_BR14                            \ Port C reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOC SECy. Note: If both BSy and BRy are set, BSy has priority.
$80000000 constant GPIOC_GPIOC_BSRR_BR15                            \ Port C reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOC SECy. Note: If both BSy and BRy are set, BSy has priority.


\
\ @brief GPIO port C configuration lock register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00002000 constant GPIOC_GPIOC_LCKR_LCK13                           \ Port C lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Access can be protected by GPIOC SECy.
$00004000 constant GPIOC_GPIOC_LCKR_LCK14                           \ Port C lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Access can be protected by GPIOC SECy.
$00008000 constant GPIOC_GPIOC_LCKR_LCK15                           \ Port C lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Access can be protected by GPIOC SECy.
$00010000 constant GPIOC_GPIOC_LCKR_LCKK                            \ Lock key This bit can be read any time. It can only be modified using the lock key write sequence. Access is protected by any GPIOC SECy. - LOCK key write sequence: WR LCKR[16] = 1 + LCKR[15:13] WR LCKR[16] = 0 + LCKR[15:13] WR LCKR[16] = 1 + LCKR[15:13] - LOCK key read RD LCKR[16] = 1 (this read operation is optional but it confirms that the lock is active) Note: During the LOCK key write sequence, the value of LCK[15:13] must not change. Note: Any error in the lock sequence aborts the LOCK. Note: After the first LOCK sequence on any bit of the port, any read access on the LCKK bit returns 1 until the next MCU reset or peripheral reset.


\
\ @brief GPIO port C alternate function high register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00f00000 constant GPIOC_GPIOC_AFRH_AFSEL13                         \ Alternate function selection for port C I/O pin 13
$0f000000 constant GPIOC_GPIOC_AFRH_AFSEL14                         \ Alternate function selection for port C I/O pin 14
$f0000000 constant GPIOC_GPIOC_AFRH_AFSEL15                         \ Alternate function selection for port C I/O pin 15 These bits are written by software to configure alternate function I/Os. Access can be protected by GPIOC SEC15.


\
\ @brief GPIO port C bit reset register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00002000 constant GPIOC_GPIOC_BRR_BR13                             \ Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOC SECy.
$00004000 constant GPIOC_GPIOC_BRR_BR14                             \ Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOC SECy.
$00008000 constant GPIOC_GPIOC_BRR_BR15                             \ Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOC SECy.


\
\ @brief GPIO port C secure configuration register
\ Address offset: 0x30
\ Reset value: 0x0000FFFF
\

$00002000 constant GPIOC_GPIOC_SECCFGR_SEC13                        \ I/O pin of port C secure bit enable y These bits are written by software to enabled the security I/O port pin.
$00004000 constant GPIOC_GPIOC_SECCFGR_SEC14                        \ I/O pin of port C secure bit enable y These bits are written by software to enabled the security I/O port pin.
$00008000 constant GPIOC_GPIOC_SECCFGR_SEC15                        \ I/O pin of port C secure bit enable y These bits are written by software to enabled the security I/O port pin.


\
\ @brief General-purpose I/Os
\
$42020800 constant GPIOC_GPIOC_MODER  \ offset: 0x00 : GPIO port C mode register
$42020804 constant GPIOC_GPIOC_OTYPER  \ offset: 0x04 : GPIO port C output type register
$42020808 constant GPIOC_GPIOC_OSPEEDR  \ offset: 0x08 : GPIOC port output speed register
$4202080c constant GPIOC_GPIOC_PUPDR  \ offset: 0x0C : GPIO port C pull-up/pull-down register
$42020810 constant GPIOC_GPIOC_IDR  \ offset: 0x10 : GPIO port C input data register
$42020814 constant GPIOC_GPIOC_ODR  \ offset: 0x14 : GPIO port C output data register
$42020818 constant GPIOC_GPIOC_BSRR  \ offset: 0x18 : GPIO port C bit set/reset register
$4202081c constant GPIOC_GPIOC_LCKR  \ offset: 0x1C : GPIO port C configuration lock register
$42020824 constant GPIOC_GPIOC_AFRH  \ offset: 0x24 : GPIO port C alternate function high register
$42020828 constant GPIOC_GPIOC_BRR  \ offset: 0x28 : GPIO port C bit reset register
$42020830 constant GPIOC_GPIOC_SECCFGR  \ offset: 0x30 : GPIO port C secure configuration register

