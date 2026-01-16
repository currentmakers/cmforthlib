\
\ @file sec_gpioh.fs
\ @brief General-purpose I/Os
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief GPIO port H mode register
\ Address offset: 0x00
\ Reset value: 0x0000C000
\

$000000c0 constant SEC_GPIOH_GPIOH_MODER_MODE3                      \ Port H configuration I/O pin 3 These bits are written by software to configure the I/O mode. Access can be protected by GPIOH SEC3.


\
\ @brief GPIO port H output type register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000008 constant SEC_GPIOH_GPIOH_OTYPER_OT3                       \ Port H configuration I/O pin 3 This bit is written by software to configure the I/O output type. Access can be protected by GPIOH SEC3.


\
\ @brief GPIO port H output speed register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000000c0 constant SEC_GPIOH_GPIOH_OSPEEDR_OSPEED3                  \ Port H configuration I/O pin 3 These bits are written by software to configure the I/O output speed. Access can be protected by GPIOH SEC3. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.


\
\ @brief GPIO port H pull-up/pull-down register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000000c0 constant SEC_GPIOH_GPIOH_PUPDR_PUPD3                      \ Port H configuration I/O pin 3 These bits are written by software to configure the I/O pull-up or pull-down Access can be protected by GPIOH SEC3.


\
\ @brief GPIO port H input data register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000008 constant SEC_GPIOH_GPIOH_IDR_ID3                          \ Port H input data I/O pin 3 This bit is read-only. It contain the input value of the corresponding I/O port. Access can be protected by GPIOH SEC3.


\
\ @brief GPIO port H output data register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000008 constant SEC_GPIOH_GPIOH_ODR_OD3                          \ Port H output data I/O pin 3 This bits can be read and written by software. Access can be protected by GPIOH SEC3. Note: For atomic bit set/reset, the OD bit can be individually set and/or reset by writing to the GPIOH_BSRR or GPIOH_BRR registers.


\
\ @brief GPIO port H bit set/reset register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000008 constant SEC_GPIOH_GPIOH_BSRR_BS3                         \ Port H set I/O pin 3 This bit is write-only. A read to this bit returns the value 0. Access can be protected by GPIOH SEC3.
$00080000 constant SEC_GPIOH_GPIOH_BSRR_BR3                         \ Port H reset I/O pin 3 This bit is write-only. A read to this bit returns the value 0. Access can be protected by GPIOH SEC3. Note: If both BS3 and BR3 are set, BS3 has priority.


\
\ @brief GPIO port H configuration lock register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000008 constant SEC_GPIOH_GPIOH_LCKR_LCK3                        \ Port H lock I/O pin 3 This bit is read/write but can only be written when the LCKK bit is 0 Access can be protected by GPIOH SEC3.
$00010000 constant SEC_GPIOH_GPIOH_LCKR_LCKK                        \ Lock key This bit can be read any time. It can only be modified using the lock key write sequence. Access is protected by GPIOH SEC3. - LOCK key write sequence: WR LCKR[16] = 1 + LCKR[3] WR LCKR[16] = 0 + LCKR[3] WR LCKR[16] = 1 + LCKR[3] - LOCK key read RD LCKR[16] = 1 (this read operation is optional but it confirms that the lock is active) Note: During the LOCK key write sequence, the value of LCK3 must not change. Note: Any error in the lock sequence aborts the LOCK. Note: After the first LOCK sequence on any bit of the port, any read access on the LCKK bit returns 1 until the next MCU reset or peripheral reset.


\
\ @brief GPIO port H alternate function low register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000f000 constant SEC_GPIOH_GPIOH_AFRL_AFSEL3                      \ Alternate function selection for port H I/O pin 3 These bits are written by software to configure alternate function I/Os. Access can be protected by GPIOH SEC3.


\
\ @brief GPIO port H bit reset register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000008 constant SEC_GPIOH_GPIOH_BRR_BR3                          \ Port H reset I/O pin 3 This bit is write-only. A read to this bit returns the value 0. Access can be protected by GPIOH SEC3.


\
\ @brief GPIO port H secure configuration register
\ Address offset: 0x30
\ Reset value: 0x0000FFFF
\

$00000008 constant SEC_GPIOH_GPIOH_SECCFGR_SEC3                     \ I/O pin of port H secure bit enable 3 This bit is written by software to enabled the security I/O port pin.


\
\ @brief General-purpose I/Os
\
$52021c00 constant SEC_GPIOH_GPIOH_MODER  \ offset: 0x00 : GPIO port H mode register
$52021c04 constant SEC_GPIOH_GPIOH_OTYPER  \ offset: 0x04 : GPIO port H output type register
$52021c08 constant SEC_GPIOH_GPIOH_OSPEEDR  \ offset: 0x08 : GPIO port H output speed register
$52021c0c constant SEC_GPIOH_GPIOH_PUPDR  \ offset: 0x0C : GPIO port H pull-up/pull-down register
$52021c10 constant SEC_GPIOH_GPIOH_IDR  \ offset: 0x10 : GPIO port H input data register
$52021c14 constant SEC_GPIOH_GPIOH_ODR  \ offset: 0x14 : GPIO port H output data register
$52021c18 constant SEC_GPIOH_GPIOH_BSRR  \ offset: 0x18 : GPIO port H bit set/reset register
$52021c1c constant SEC_GPIOH_GPIOH_LCKR  \ offset: 0x1C : GPIO port H configuration lock register
$52021c20 constant SEC_GPIOH_GPIOH_AFRL  \ offset: 0x20 : GPIO port H alternate function low register
$52021c28 constant SEC_GPIOH_GPIOH_BRR  \ offset: 0x28 : GPIO port H bit reset register
$52021c30 constant SEC_GPIOH_GPIOH_SECCFGR  \ offset: 0x30 : GPIO port H secure configuration register

